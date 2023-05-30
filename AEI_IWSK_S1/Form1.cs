using System.IO.Ports;
using System.Windows.Forms;

namespace AEI_IWSK_S1
{
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
                    Bart³omiej Ajchler
                    £ukasz B³aszczyk
                    Sebastian Fija³kowski
                    Roman Gawenda
                    Micha³ Kapuœciñski

                    """, "Twórcy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ustawienia po³¹czenia, menu kontekstowe z parametrami do wyboru.
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

        private void wyjœcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Za³aduj obiekt po³¹czenia

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
        //Tutaj nie do koñca wiem jak to ma dzia³aæ.
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
            this.connectionInfoLabel.Text = "";
            try
            {
                this.serial = new SerialPort(this.connectionData.portName);
            }
            catch (Exception ex)
            {
                this.connectionInfoLabel.Text = "Podany port nie istnieje!";
                return;
            }
            this.serial.BaudRate = this.connectionData.baudRate == 0 ? 100 : this.connectionData.baudRate; 
            this.serial.Parity =  this.deduceParity();
            this.serial.DataBits = this.deduceDataBits();
            this.serial.StopBits = this.deduceStopBits();
            this.serial.Handshake = this.deduceHandshake();
        }
    }
}