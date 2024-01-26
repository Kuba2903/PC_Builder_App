using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Motherboards
{
    public class AorusEliteMotherBoard : IComputerMotherBoard
    {
        public bool BackLight() => false;

        public int GBMaximumMemory() => 128;

        public byte MemorySlots() => 4;

        public string MemoryType() => "DDR4";

        public MotherBoardTypes MotherBoardStandard() => MotherBoardTypes.MiniATX;

        public string Name() => "Aorus Elite";

        public double Price() => 119.99;

        public Socket SocketType() => Socket.LGA1151;
    }
}
