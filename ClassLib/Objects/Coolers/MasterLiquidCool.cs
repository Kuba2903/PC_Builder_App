using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Coolers
{
    public class MasterLiquidCool : IComputerCooler
    {
        public bool BackLight() => true;

        public List<Socket> CompatibleSockets()
        {
            List<Socket> sockets = new List<Socket>();
            sockets.Add(Socket.LGA1700);
            sockets.Add(Socket.LGA1200);
            sockets.Add(Socket.LGA1151);
            sockets.Add(Socket.LGA2066);
            sockets.Add(Socket.AM5);
            sockets.Add(Socket.AM4);
            sockets.Add(Socket.TR4);
            return sockets;
        }

        public string CoolerType() => "Liquid cooler";

        public double Price() => 124.99;

        public string Producer() => "Master Liquid";
    }
}
