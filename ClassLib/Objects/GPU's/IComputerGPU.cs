using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.GPU_s
{
    public interface IComputerGPU
    {
        string Producer();

        double Price();

        string Model();

        string MemoryType();

        int GBMemory(); //memory in gb

        bool BackLight();
    }
}
