using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEI_IWSK_S1
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

            this.portComboBox.Items.AddRange(SerialPort.GetPortNames());
            //this.baudComboBox.Items.AddRange(Connection.baudRates);
        }
    }
}
