using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.GPU_s
{
    public class RX7600GPU : IComputerGPU
    {
        public bool BackLight() => true;

        public int GBMemory() => 12;

        public string MemoryType() => "GDDR6";

        public string Model() => "Radeon RX 7600";

        public double Price() => 600;

        public string Producer() => "AMD";
    }
}
