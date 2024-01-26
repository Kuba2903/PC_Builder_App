using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.CPU_s
{
    public class I5_124CPU : IComputerCPU
    {
        public double ClockSpeed() => 3.4;

        public string Model() => "Core i5-12400F";

        public int NumberOfCores() => 8;

        public double Price() => 299.99;

        public string Producer() => "Intel";

        public Socket SocketType() => Socket.LGA1700;
    }
}
