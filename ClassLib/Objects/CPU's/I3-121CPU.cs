using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.CPU_s
{
    public class I3_121CPU : IComputerCPU
    {
        public double ClockSpeed() => 2.8;

        public string Model() => "Core I3-12100F";

        public int NumberOfCores() => 4;

        public double Price() => 109.99;

        public string Producer() => "Intel";

        public Socket SocketType() => Socket.LGA1200;
    }
}
