using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.CPU_s
{
    public class Ryzen7CPU : IComputerCPU
    {
        public double ClockSpeed() => 5;

        public string Model() => "Ryzen 7 7800X3D";

        public int NumberOfCores() => 8;

        public double Price() => 379.99;

        public string Producer() => "AMD";

        public Socket SocketType() => Socket.AM5;
    }
}
