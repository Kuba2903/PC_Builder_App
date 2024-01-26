using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.GPU_s
{
    public class RX4200GPU : IComputerGPU
    {
        public bool BackLight() => false;

        public int GBMemory() => 4;

        public string MemoryType() => "GDDR5";

        public string Model() => "Radeon RX 4200";

        public double Price() => 149.99;

        public string Producer() => "AMD";
    }
}
