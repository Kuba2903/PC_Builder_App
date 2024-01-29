using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.GPU_s
{
    public class RTX4060GPU : IComputerGPU
    {
        public bool BackLight() => true;

        public int GBMemory() => 8;

        public string MemoryType() => "GDDR6";

        public string Model() => "RTX 4060";

        public double Price() => 549.99;

        public string Producer() => "Nvidia";
    }
}
