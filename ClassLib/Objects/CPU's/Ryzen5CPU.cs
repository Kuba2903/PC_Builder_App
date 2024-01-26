using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.CPU_s
{
    public class Ryzen5CPU : IComputerCPU
    {
        public double ClockSpeed() => 3.7;

        public string Model() => "Ryzen 5 7500F";

        public int NumberOfCores() => 6;

        public double Price() => 219.99;

        public string Producer() => "AMD";

        public Socket SocketType() => Socket.AM4;
    }
}
