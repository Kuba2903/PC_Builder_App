using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Keyboards
{
    public class SteelSeriesGamingKeyboard : IKeyboard
    {
        public bool BackLight() => true;

        public double Price() => 119.99;

        public string Producer() => "Steel Series";

        public bool Wireless() => false;
    }
}
