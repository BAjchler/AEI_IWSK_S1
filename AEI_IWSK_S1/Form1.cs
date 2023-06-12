using System.Drawing.Design;
using System.IO.Ports;
using System.Windows.Forms;
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
        public Connection connectionData = new Connection();
        ConnectionForm connectionForm;
        public SerialPort serial;

        public Form1()
        {
            InitializeComponent();
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
            else if(!connectionForm.Visible)
            {
                connectionForm.Show();
            }
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Załaduj obiekt połączenia

        }

        private Parity deduceParity()
        {
            switch(this.connectionData.parity)
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
            switch(this.connectionData.dataLength)
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
            switch(this.connectionData.stopBitsLength)
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
            switch(this.connectionData.dataFlow)
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
            this.serial.Parity =  this.deduceParity();
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
            try {
                this.serial.Open();
                this.logConnection("Port został otwarty!", LOGLEVEL.INFO);
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