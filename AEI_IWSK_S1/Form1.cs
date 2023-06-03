using System.IO.Ports;
using System.Windows.Forms;

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

        private void tw�rcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                    Projekt AEI IWSK Katowice 2023r.
                    Komunikacja przez port znakowy.
                    ----------------------------------------------------------
                    Tw�rcy:
                    Krzysztof Adamczyk
                    Bart�omiej Ajchler
                    Piotr Benio
                    �ukasz B�aszczyk
                    Dominik Cio�czyk
                    Sebastian Fija�kowski
                    Roman Gawenda
                    Bartosz Ja�owiecki
                    Micha� Kapu�ci�ski
                    Marcin Kny�
                    Kamil Musia�owski
                    Micha� Niedbalski
                    Grzegorz Nowak
                    Kamil Szota

                    """, "Tw�rcy", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Ustawienia po��czenia, menu kontekstowe z parametrami do wyboru.
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

        private void wyj�cieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Za�aduj obiekt po��czenia

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
                case "siedem bit�w":
                    return 7;
                case "osiem bit�w":
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
        //Tutaj nie do ko�ca wiem jak to ma dzia�a�.
        private Handshake deduceHandshake()
        {
            switch(this.connectionData.dataFlow)
            {
                case "brak":
                    return Handshake.None;
                case "XON/XOFF":
                    return Handshake.XOnXOff;
                case "RTS/CTS":
                    return Handshake.RequestToSend;
                default: return Handshake.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.serial is not null && this.serial.IsOpen)
            {
                this.serial.Close();
            }
            try
            {
                this.serial = new SerialPort(this.connectionData.portName);
                this.logConnection("Gotowy do otwarcia portu", LOGLEVEL.INFO);
            }
            catch (Exception ex)
            {
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
                this.logConnection("Brak definicji po��czenia!", LOGLEVEL.ERROR);
                return;
            }
            if (this.serial.IsOpen)
            {
                return;
            }
            try {
                this.serial.Open();
                this.logConnection("Port zosta� otwarty!", LOGLEVEL.INFO);
            }
            catch (Exception ex)
            {
                this.logConnection("Port nie zosta� otwarty!", LOGLEVEL.ERROR);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.serial is not null && this.serial.IsOpen)
            {
                this.serial.Close();
                this.logConnection("Port zosta� zamkni�ty!", LOGLEVEL.WARNING);
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
                case "W�asny":
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
                this.logConnection("Po��czenie nie zosta�o otwarte lub zdefiniowane!", LOGLEVEL.ERROR);
            }
        }
    }
}