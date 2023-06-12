using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AEI_IWSK_S1
{
    public class Connection
    {
        public static readonly object[] baudRates = {150, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000};
        public static readonly String[] parityOptions = { "brak", "nieparzyste", "parzyste" };
        public static readonly String[] stopBits = {"jeden", "dwa" };
        public static readonly String[] dataField = { "siedem bitów", "osiem bitów"};
        public static readonly String[] flowField = { "brak", "sprzętowa", "programowa" };
        public static readonly String[] terminatorField = { "brak", "CR", "LF", "CR-LF", "Własny"};

        public int baudRate { get; set; }
        public String portName { get; set; }
        public String parity { get; set; }
        public String stopBitsLength { get; set; }
        public String dataLength { get; set; }
        public String dataFlow { get; set; }
        public String terminator { get; set; }
        public String customTerminator { get; set; }

        public Connection() { }

    }
}
