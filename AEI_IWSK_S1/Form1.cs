using System.Diagnostics;
using System.Drawing.Design;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using System.Text;

namespace AEI_IWSK_S1
{
    enum LOGLEVEL
    {
        INFO,
        WARNING,
        ERROR
    }

    public partial class Form1 : Form
    {
        // Ping constants
        private const byte PING_REQUEST = 0xFF;
        private const byte PING_RESPONSE = 0xEF;
        private const int PING_TIMEOUT_MS = 2000;

        // Transaction constants
        private const byte TRANSACTION_REQUEST = 0xDF;
        private const byte TRANSACTION_CONFIRM = 0xCF;
        private const byte TRANSACTION_DENY = 0xBF;
        private const byte TRANSACTION_END = 0xAF;
        private const int TRANSACTION_TIMEOUT_MS = 2000;

        // Terminator constants
        private char[] TERM_CR = { '\x000D' };
        private char[] TERM_LF = { '\x000A' };
        private char[] TERM_CRLF = { '\x000D', '\x000A' };

        // Connection variables
        public Connection connectionData = new Connection();
        ConnectionForm connectionForm;
        public SerialPort serial;

        // Timers
        private System.Timers.Timer pingTimeoutTimer;
        private Stopwatch pingRoundTripTimer;
        private System.Timers.Timer transactionTimeoutTimer;

        // Others
        private bool pingTimeoutReached;
        private bool transactionTimeoutReached;
        private bool transactionInProgress;

        public Form1()
        {
            InitializeComponent();
        }

        delegate void updateStateCallback();

        private void updateState()
        {
            if (this.ctsState.InvokeRequired || this.dsrState.InvokeRequired)
            {
                updateStateCallback d = new updateStateCallback(updateState);
                this.Invoke(d);
            }
            else
            {
                this.ctsState.Text = this.serial.CtsHolding ? "Wysokie" : "Niskie";
                this.dsrState.Text = this.serial.DsrHolding ? "Wysokie" : "Niskie";
            }
        }

        public void checkState(object sender, EventArgs e)
        {
            if (serial is null) {
                return;
            }
            else
            {
                updateState();
            }
        }


        private void twórcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                    Projekt AEI IWSK Katowice 2023r.
                    Komunikacja przez port znakowy.
                    ----------------------------------------------------------
                    Twórcy:
                    Krzysztof Adamczyk
                    Bartłomiej Ajchler
                    Piotr Benio
                    Łukasz Błaszczyk
                    Dominik Ciołczyk
                    Sebastian Fijałkowski
                    Roman Gawenda
                    Bartosz Jałowiecki
                    Michał Kapuściński
                    Szymon Moc
                    Kamil Musiałowski
                    Michał Niedbalski
                    Grzegorz Nowak
                    Kamil Szota

                    """, "Twórcy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region PING
        delegate void SetPingInfoCallback(String text);

        private void SetPingInfo(String text)
        {
            if(this.textBox2.InvokeRequired)
            {
                SetPingInfoCallback callback = new SetPingInfoCallback(SetPingInfo);
                this.Invoke(callback, new object[] {text});
            }
            else
            {
                this.textBox2.Text = text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serial != null && serial.IsOpen)
            {
                StartPingTimeoutTimer();
                serial.Write(new byte[] { PING_REQUEST }, 0, 1);
            }
            else
            {
                logConnection("Połączenie nie zostało otwarte lub zdefiniowane!", LOGLEVEL.ERROR);
            }
        }

        private void StartPingTimeoutTimer()
        {
            pingRoundTripTimer = new Stopwatch();
            pingTimeoutTimer = new System.Timers.Timer(PING_TIMEOUT_MS);
            pingTimeoutTimer.Elapsed += OnTimeoutEvent;
            pingTimeoutTimer.Start();
            pingRoundTripTimer.Start();
            pingTimeoutReached = false;
        }

        private void OnTimeoutEvent(object sender, EventArgs e)
        {
            float elapsedMs = ((float)pingRoundTripTimer.ElapsedTicks) / (((float)Stopwatch.Frequency) / (1000L * 1000L));
            elapsedMs /= 1000;
            string msg = "Ping timeout: " + elapsedMs.ToString("0.00") + "ms";
            SetPingInfo(msg);
            pingTimeoutTimer.Dispose();
            pingRoundTripTimer.Stop();
            pingTimeoutReached = true;
        }
        #endregion

        #region CONNECTION_UTILS
        private void logConnection(string msg, LOGLEVEL level)
        {
            switch (level)
            {
                case LOGLEVEL.INFO:
                    this.connectionInfoLabel.ForeColor = Color.Black;
                    this.connectionInfoLabel.Text = msg;
                    return;
                case LOGLEVEL.WARNING:
                    this.connectionInfoLabel.ForeColor = Color.Orange;
                    this.connectionInfoLabel.Text = msg;
                    return;
                case LOGLEVEL.ERROR:
                    this.connectionInfoLabel.ForeColor = Color.Red;
                    this.connectionInfoLabel.Text = msg;
                    return;
            }
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ustawienia połączenia, menu kontekstowe z parametrami do wyboru.
            if (connectionForm is null || connectionForm.IsDisposed)
            {
                connectionForm = new ConnectionForm(connectionData);
                connectionForm.Show();
            }
            else if (!connectionForm.Visible)
            {
                connectionForm.Show();
            }
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Parity deduceParity()
        {
            switch (this.connectionData.parity)
            {
                case "brak":
                    return Parity.None;
                case "nieparzyste":
                    return Parity.Odd;
                case "parzyste":
                    return Parity.Even;
                default: return Parity.None;
            }
        }

        private int deduceDataBits()
        {
            switch (this.connectionData.dataLength)
            {
                case "siedem bitów":
                    return 7;
                case "osiem bitów":
                    return 8;
                default: return 7;
            }
        }

        private StopBits deduceStopBits()
        {
            switch (this.connectionData.stopBitsLength)
            {
                case "jeden":
                    return StopBits.One;
                case "dwa":
                    return StopBits.Two;
                default:
                    return StopBits.One;
            }
        }
        private Handshake deduceHandshake()
        {
            switch (this.connectionData.dataFlow)
            {
                case "brak":
                    return Handshake.None;
                case "programowa":
                    return Handshake.XOnXOff;
                case "sprzętowa":
                    return Handshake.RequestToSend;
                default: return Handshake.None;
            }
        }

        private void changeStateOfManualControl(bool state)
        {
            this.manualControlGroupBox.Enabled = state;
            this.dtrEnableCheckBox.Enabled = state;
            this.rtsEnableCheckBox.Enabled = state;
        }
        #endregion

        #region CONNECTION
        private void button1_Click(object sender, EventArgs e)
        {
            this.dtrEnableCheckBox.Checked = false;
            this.rtsEnableCheckBox.Checked = false;
            if (this.serial is not null && this.serial.IsOpen)
            {
                this.serial.Close();
            }
            try
            {
                this.serial = new SerialPort(this.connectionData.portName);
                this.serial.PinChanged += this.checkState;
                if (this.deduceHandshake() == Handshake.RequestToSend)
                {
                    changeStateOfManualControl(true);
                }
                else
                {
                    dtrEnableCheckBox.Checked = false;
                    rtsEnableCheckBox.Checked = false;
                    changeStateOfManualControl(false);
                }
                this.logConnection("Gotowy do otwarcia portu", LOGLEVEL.INFO);
            }
            catch (Exception ex)
            {
                changeStateOfManualControl(false);
                this.logConnection("Podany port nie istnieje!", LOGLEVEL.ERROR);
                return;
            }
            this.serial.BaudRate = this.connectionData.baudRate == 0 ? 150 : this.connectionData.baudRate;
            this.serial.Parity = this.deduceParity();
            this.serial.DataBits = this.deduceDataBits();
            this.serial.StopBits = this.deduceStopBits();
            this.serial.Handshake = this.deduceHandshake();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.serial is null)
            {
                this.logConnection("Brak definicji połączenia!", LOGLEVEL.ERROR);
                return;
            }
            if (this.serial.IsOpen)
            {
                return;
            }
            try
            {
                this.serial.Open();
                serial.DataReceived += new SerialDataReceivedEventHandler(serial_TransactionDataRecieved);
                this.logConnection("Port został otwarty!", LOGLEVEL.INFO);
                this.ctsState.Text = this.serial.CtsHolding ? "Wysokie" : "Niskie";
                this.dsrState.Text = this.serial.DsrHolding ? "Wysokie" : "Niskie";
                transactionInProgress = false;
            }
            catch (Exception ex)
            {
                this.logConnection("Port nie został otwarty!", LOGLEVEL.ERROR);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.serial is not null && this.serial.IsOpen)
            {
                this.serial.Close();
                this.logConnection("Port został zamknięty!", LOGLEVEL.WARNING);
            }
        }
        private String appendTerminator()
        {
            String msg = this.textBox1.Text;
            switch (this.connectionData.terminator)
            {
                case "brak":
                    break;
                case "CR":
                    msg += '\x000D';
                    break;
                case "LR":
                    msg += '\x000A';
                    break;
                case "CR-LF":
                    msg = (msg + '\x000D') + '\x000A';
                    break;
                case "Własny":
                    msg += this.connectionData.customTerminator;
                    break;
            }
            return msg;
        }
        
        #endregion

        #region TRANSACTION
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.serial != null && this.serial.IsOpen)
            {
                this.serial.Write(new byte[] {TRANSACTION_REQUEST}, 0, 1);
                this.serial.Write(new byte[] { TRANSACTION_REQUEST }, 0, 1);
                StartTrancationTimeoutTimer();
            }
            else
            {
                this.logConnection("Połączenie nie zostało otwarte lub zdefiniowane!", LOGLEVEL.ERROR);
            }
        }

        private void serial_TransactionDataRecieved(object sender, EventArgs e)
        {
            if(transactionInProgress == false)
            {
                if (serial == null || !serial.IsOpen) return;
                if(serial.BytesToRead == 1)
                {
                    byte[] buffer = new byte[1];
                    serial.Read(buffer, 0, buffer.Length);
                    switch (buffer[0])
                    {
                        case TRANSACTION_CONFIRM:
                            transactionInProgress = false;
                            serial.Write(appendTerminator());
                            transactionTimeoutTimer.Dispose();
                            break;

                        case TRANSACTION_DENY:
                            transactionInProgress = false;
                            transactionTimeoutTimer.Dispose();
                            SetTransactionResponse("Transakcja odrzucona przez klienta");
                            break;

                        case TRANSACTION_REQUEST:
                            if (transactionInProgress == true)
                            {
                                serial.Write(new byte[] { TRANSACTION_DENY }, 0, 1);
                                return;
                            }
                            transactionInProgress = true;
                            serial.Write(new byte[] { TRANSACTION_CONFIRM }, 0, 1);
                            StartTrancationTimeoutTimer();
                            break;

                        case PING_REQUEST:
                            serial.Write(new byte[] { PING_RESPONSE }, 0, 1);
                            break;

                        case PING_RESPONSE:
                            if (pingTimeoutReached == true || pingRoundTripTimer == null) return;
                            float elapsedMs = ((float)pingRoundTripTimer.ElapsedTicks) / (((float)Stopwatch.Frequency) / (1000L * 1000L));
                            elapsedMs /= 1000;
                            string msg = "Ping success: " + elapsedMs.ToString("0.00") + "ms";
                            pingTimeoutTimer.Dispose();
                            pingRoundTripTimer.Stop();
                            SetPingInfo(msg);
                            break;

                        default:
                            return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (serial == null || !serial.IsOpen) return;
                if (serial.BytesToRead > 0)
                {
                    byte[] buffer = new byte[serial.BytesToRead];
                    string term = string.Empty;
                    string msg = string.Empty;
                    switch(connectionData.terminator)
                    {
                        case "brak":
                            break;
                        case "CR":
                            term += '\x000D';
                            break;
                        case "LR":
                            term += '\x000A';
                            break;
                        case "CR-LF":
                            term = (term + '\x000D') + '\x000A';
                            break;
                        case "Własny":
                            term = this.connectionData.customTerminator;
                            break;
                    }
                    if(term.Equals(""))
                    {
                        serial.Read(buffer, 0, serial.BytesToRead);
                        msg = System.Text.Encoding.Default.GetString(buffer);
                    }
                    else
                    {
                        msg += serial.ReadTo(term);
                        byte[] discardBuffer = new byte[serial.BytesToRead];
                        serial.Read(discardBuffer, 0, serial.BytesToRead);
                    }
                    transactionInProgress = false;
                    transactionTimeoutTimer.Dispose();
                    SetTransactionResponse(msg);
                }
                else
                {
                    transactionInProgress = false;
                    transactionTimeoutTimer.Dispose();
                    return;
                }
            }
            return;
        }

        private void StartTrancationTimeoutTimer()
        {
            transactionTimeoutTimer = new System.Timers.Timer(TRANSACTION_TIMEOUT_MS);
            transactionTimeoutTimer.Elapsed += OnTransactionTimeout;
            transactionTimeoutTimer.Start();
            transactionTimeoutReached = false;          
        }

        private void OnTransactionTimeout(object sender, EventArgs e)
        {
            transactionInProgress = false;
            transactionTimeoutTimer.Dispose();
            SetTransactionResponse("Transaction timeout");
        }

        delegate void SetTransactionResponseCallback(string text);

        private void SetTransactionResponse(string text)
        {
            if (this.textBox2.InvokeRequired)
            {
                SetTransactionResponseCallback callback = new SetTransactionResponseCallback(SetTransactionResponse);
                this.Invoke(callback, new object[] { text });
            }
            else
            {
                this.textBox2.Text = text;
            }
        }
        #endregion

        #region DTR_RTS_UTILS
        private void dtrEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.serial is null)
            {
                dtrEnableCheckBox.Checked = false;
                rtsEnableCheckBox.Checked = false;
                changeStateOfManualControl(false);
                this.logConnection("Połączenie zostało nagle zamknięte!", LOGLEVEL.ERROR);
                return;
            }
            if (dtrEnableCheckBox.Checked)
            {
                this.serial.DtrEnable = true;
            }
            else
            {
                this.serial.DtrEnable = false;
            }
        }

        private void rtsEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.serial is null)
            {
                dtrEnableCheckBox.Checked = false;
                rtsEnableCheckBox.Checked = false;
                changeStateOfManualControl(false);
                this.logConnection("Połączenie zostało nagle zamknięte!", LOGLEVEL.ERROR);
                return;
            }
            if (dtrEnableCheckBox.Checked)
            {
                this.serial.RtsEnable = true;
            }
            else
            {
                this.serial.RtsEnable = false;
            }
        }
        #endregion
        
        #region HEX
        byte[] binaryBuffer;

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Uri.IsHexDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }
        private void UpdateText()
        {
            textBox1.TextChanged -= textBox1_TextChanged;
            textBox1.Text = Encoding.Default.GetString(binaryBuffer);
            textBox1.TextChanged += textBox1_TextChanged;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string[] hexValues = textBox3.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            binaryBuffer = new byte[hexValues.Length];

            for (int i = 0; i < binaryBuffer.Length; i++)
                binaryBuffer[i] = byte.TryParse(hexValues[i],
                    System.Globalization.NumberStyles.HexNumber, null, out byte value)
                    ? value
                    : (byte)0;
            UpdateText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            binaryBuffer = Encoding.Default.GetBytes(textBox1.Text);
            UpdateHex();
        }
        private void UpdateHex()
        {
            textBox3.TextChanged -= textBox3_TextChanged;
            textBox3.Text = BitConverter.ToString(binaryBuffer).Replace("-", " ");
            textBox3.TextChanged += textBox3_TextChanged;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                binaryBuffer = File.ReadAllBytes(ofd.FileName);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
            UpdateHex();
            UpdateText();
        }
        #endregion
    }
}