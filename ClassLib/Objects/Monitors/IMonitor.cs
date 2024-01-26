using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Monitors
{
    public interface IMonitor
    {
        string Producer();

        double Price();

        int ScreenRefreshHZ();

        string Resolution();

        string ScreenProportion();

        List<string> Connectors(); //ex. vga, hdmi etc.
    }
}
