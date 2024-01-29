using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.CPU_s
{
    public interface IComputerCPU
    {
        Socket SocketType();

        string Model();

        string Producer();

        double ClockSpeed();

        int NumberOfCores();

        double Price();
    }
}
