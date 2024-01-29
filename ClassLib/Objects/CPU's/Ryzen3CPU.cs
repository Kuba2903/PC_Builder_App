using ClassLib.Enums;
using ClassLib.ObjectsInterfaces.CPU_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Objects.CPU_s
{
    public class Ryzen3CPU : IComputerCPU
    {
        public double ClockSpeed() => 2.9;

        public string Model() => "Ryzen 3";

        public int NumberOfCores() => 4;

        public double Price() => 99.99;

        public string Producer() => "AMD";

        public Socket SocketType() => Socket.TR4;
    }
}
