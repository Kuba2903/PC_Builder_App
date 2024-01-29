using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Mouse
{
    public class GamingMouse : IMouse
    {
        public bool BackLight() => true;

        public double Price() => 79.99;

        public string Producer() => "GameMouse";

        public bool Wireless() => false;
    }
}
