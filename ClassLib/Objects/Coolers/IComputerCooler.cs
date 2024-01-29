using ClassLib.Enums;
using ClassLib.ObjectsInterfaces.CPU_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Coolers
{
    public interface IComputerCooler
    {
        List<Socket> CompatibleSockets();

        double Price();

        string CoolerType();

        bool BackLight();

        string Producer();
    }
}
