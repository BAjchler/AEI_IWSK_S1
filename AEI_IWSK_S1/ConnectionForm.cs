using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEI_IWSK_S1
{
    public partial class ConnectionForm : Form
    {
        private Connection connection;
        public ConnectionForm(Connection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            this.portComboBox.Items.AddRange(SerialPort.GetPortNames());
            this.baudComboBox.Items.AddRange(Connection.baudRates);
            this.parityComboBox.Items.AddRange(Connection.parityOptions);
            this.stopBitsComboBox.Items.AddRange(Connection.stopBits);
            this.dataFieldComboBox.Items.AddRange(Connection.dataField);
            this.flowControlComboBox.Items.AddRange(Connection.flowField);
            this.terminatorComboBox.Items.AddRange(Connection.terminatorField);
            this.portComboBox.SelectedIndex = this.portComboBox.FindStringExact(this.connection.portName);
            this.baudComboBox.SelectedIndex = this.baudComboBox.FindStringExact(this.connection.baudRate.ToString());
            this.parityComboBox.SelectedIndex = this.parityComboBox.FindStringExact(this.connection.parity);
            this.stopBitsComboBox.SelectedIndex = this.stopBitsComboBox.FindStringExact(this.connection.stopBitsLength);
            this.dataFieldComboBox.SelectedIndex = this.dataFieldComboBox.FindStringExact(this.connection.dataLength);
            this.flowControlComboBox.SelectedIndex = this.flowControlComboBox.FindStringExact(this.connection.dataFlow);
            this.terminatorComboBox.SelectedIndex = this.terminatorComboBox.FindStringExact(this.connection.terminator);
            this.customTerminatorBox.Text = this.connection.customTerminator;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (portComboBox.SelectedIndex > -1) { this.connection.portName = (String)portComboBox.SelectedItem; }
            if (baudComboBox.SelectedIndex > -1) { this.connection.baudRate = (int)baudComboBox.SelectedItem; }
            if (parityComboBox.SelectedIndex > -1) { this.connection.parity = (String)parityComboBox.SelectedItem; }
            if (stopBitsComboBox.SelectedIndex > -1) { this.connection.stopBitsLength = (String)stopBitsComboBox.SelectedItem; }
            if (dataFieldComboBox.SelectedIndex > -1) { this.connection.dataLength = (String)dataFieldComboBox.SelectedItem; }
            if (flowControlComboBox.SelectedIndex > -1) { this.connection.dataFlow = (String)flowControlComboBox.SelectedItem; }
            if (terminatorComboBox.SelectedIndex > -1) { this.connection.terminator = (String)terminatorComboBox.SelectedItem; }
            this.connection.customTerminator = customTerminatorBox.Text;
        }
    }
}
