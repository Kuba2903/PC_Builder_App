using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Mouse
{
    public class LogitechMouse : IMouse
    {
        public bool BackLight() => false;

        public double Price() => 49.99;

        public string Producer() => "Logitech";

        public bool Wireless() => true;
    }
}
