using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.GPU_s
{
    public class GTX1650GPU : IComputerGPU
    {
        public bool BackLight() => false;

        public int GBMemory() => 4;

        public string MemoryType() => "GDDR6";

        public string Model() => "GTX 1650";

        public double Price() => 299.99;

        public string Producer() => "Nvidia";
    }
}
