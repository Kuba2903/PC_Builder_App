using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Monitors
{
    public class PhilipsMonitor : IMonitor
    {
        public List<string> Connectors()
        {
            List<string> con = new List<string>();
            con.Add("VGA");
            con.Add("HDMI");
            return con;
        }

        public double Price() => 149.99;


        public string Producer() => "Philips";

        public string Resolution() => "1920x1080";

        public string ScreenProportion() => "21:9" ;

        public int ScreenRefreshHZ() => 120;
    }
}
