using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.RAMSticks
{
    public interface IComputerRAMStick
    {
        string Producer();

        double Price();

        string RAMType(); //ex. DDR4, DDR3 etc..

        int GBMemoryAmount(); //memory in gb

        bool BackLight();
    }
}
