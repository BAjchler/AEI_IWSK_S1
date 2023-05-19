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
    internal class Connection
    {
        public static readonly object[] baudRates = {110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000};
        public static readonly String[] parityOptions = { "brak", "nieparzyste", "parzyste" };
        public static readonly String[] stopBits = { "brak", "jeden", "dwa" };
        public static readonly String[] dataField = { "siedem bitów", "osiem bitów"};


        public Connection() { }


    }
}
