using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Coolers
{
    public class AsusCool : IComputerCooler
    {
        public bool BackLight() => false;

        public List<Socket> CompatibleSockets()
        {
            List<Socket> sockets = new List<Socket>();
            sockets.Add(Socket.AM5);
            sockets.Add(Socket.AM4);
            sockets.Add(Socket.TR4);
            return sockets;
        }

        public string CoolerType() => "Fan cooler";

        public double Price() => 99.99;

        public string Producer() => "Asus";
    }
}
