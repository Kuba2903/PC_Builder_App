using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Monitors
{
    public class Toshiba43UAMonitor : IMonitor
    {
        public List<string> Connectors()
        {
            List<string> con = new List<string>();
            con.Add("VGA");
            con.Add("HDMI");
            con.Add("DVI");
            return con;
        }

        public double Price() => 299.99;

        public string Producer() => "Toshiba";

        public string Resolution() => "1920x1080";

        public string ScreenProportion() => "16:9";

        public int ScreenRefreshHZ() => 140;
    }
}
