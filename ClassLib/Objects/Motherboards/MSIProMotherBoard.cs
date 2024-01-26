using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Motherboards
{
    public class MSIProMotherBoard : IComputerMotherBoard
    {
        public bool BackLight() => false;

        public int GBMaximumMemory() => 64;

        public byte MemorySlots() => 2;

        public string MemoryType() => "DDR4";

        public MotherBoardTypes MotherBoardStandard() => MotherBoardTypes.MicroATX;

        public string Name() => "MSI Pro";

        public double Price() => 79.99;

        public Socket SocketType() => Socket.TR4;
    }
}
