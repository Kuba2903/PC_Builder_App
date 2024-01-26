using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Keyboards
{
    public class LogitechG915Keyboard : IKeyboard
    {
        public bool BackLight() => false;

        public double Price() => 89.99;

        public string Producer() => "Logitech";

        public bool Wireless() => true;
    }
}
