using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Coolers
{
    public class DeepCool : IComputerCooler
    {
        public bool BackLight() => false;

        public List<Socket> CompatibleSockets()
        {
            List<Socket> sockets = new List<Socket>();
            sockets.Add(Socket.LGA1700);
            sockets.Add(Socket.LGA1200);
            sockets.Add(Socket.LGA1151);
            sockets.Add(Socket.LGA2066);
            return sockets;
        }

        public string CoolerType() => "Fan Cooler";

        public double Price() => 149.99;

        public string Producer() => "Deep Cool";
    }
}
