using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.RAMSticks
{
    public class CorsairRAM : IComputerRAMStick
    {
        public bool BackLight() => true;

        public int GBMemoryAmount() => 16;

        public double Price() => 79.99;

        public string Producer() => "Corsair";

        public string RAMType() => "DDR5";
    }
}
