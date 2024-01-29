using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.RAMSticks
{
    public class KingstonFuryRAM : IComputerRAMStick
    {
        public bool BackLight() => false;

        public int GBMemoryAmount() => 8;

        public double Price() => 59.99;

        public string Producer() => "Kingston Fury";

        public string RAMType() => "DDR5";
    }
}
