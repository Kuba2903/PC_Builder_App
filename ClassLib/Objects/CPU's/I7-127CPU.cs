using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.CPU_s
{
    public class I7_127CPU : IComputerCPU
    {
        public double ClockSpeed() => 4.5;

        public string Model() => "Core i7-12700KF";

        public int NumberOfCores() => 12;

        public double Price() => 400.99;

        public string Producer() => "Intel";

        public Socket SocketType() => Socket.LGA1700;
    }
}
