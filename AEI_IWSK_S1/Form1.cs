using System.Diagnostics;
using System.Drawing.Design;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

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
        private const byte PING_REQUEST = 0xFF;
        private const byte PING_RESPONSE = 0xFE;
        private const int PING_TIMEOUT_MS = 2000;

        public Connection connectionData = new Connection();
        ConnectionForm connectionForm;
        public SerialPort serial;

        private System.Timers.Timer pingTimeoutTimer;
        private Stopwatch pingRoundTripTimer;
        private bool pingTimeoutReached;

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

        private void serial_PingDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            if(serial == null || !serial.IsOpen)
            {
                return;
            }
            byte[] buffer = new byte[1];
            serial.Read(buffer, 0, buffer.Length);
            if (buffer[0] == PING_REQUEST)
            {
                serial.Write(new byte[] { PING_RESPONSE }, 0, 1);
            }
            else if (buffer[0] == PING_RESPONSE)
            {
                if(pingTimeoutReached == false && pingRoundTripTimer is not null)
                {
                    float elapsedMs = ((float)pingRoundTripTimer.ElapsedTicks) / (((float)Stopwatch.Frequency) / (1000L * 1000L));
                    elapsedMs /= 1000;
                    string msg = "Ping success: " + elapsedMs.ToString("0.00") + "ms";
                    pingTimeoutTimer.Dispose();
                    pingRoundTripTimer.Stop();
                    SetPingInfo(msg);
                }
                
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
                serial.DataReceived += new SerialDataReceivedEventHandler(serial_PingDataRecieved);
                this.logConnection("Port został otwarty!", LOGLEVEL.INFO);
                this.ctsState.Text = this.serial.CtsHolding ? "Wysokie" : "Niskie";
                this.dsrState.Text = this.serial.DsrHolding ? "Wysokie" : "Niskie";
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.serial != null && this.serial.IsOpen)
            {
                this.serial.Write(appendTerminator());

            }
            else
            {
                this.logConnection("Połączenie nie zostało otwarte lub zdefiniowane!", LOGLEVEL.ERROR);
            }
        }

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

        

    }
}