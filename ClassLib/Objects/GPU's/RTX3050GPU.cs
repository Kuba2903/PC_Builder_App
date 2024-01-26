using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.GPU_s
{
    public class RTX3050GPU : IComputerGPU
    {
        public bool BackLight() => true;

        public int GBMemory() => 12;

        public string MemoryType() => "GDDR6";

        public string Model() => "RTX 3050";

        public double Price() => 719.99;

        public string Producer() => "Nvidia";
    }
}
