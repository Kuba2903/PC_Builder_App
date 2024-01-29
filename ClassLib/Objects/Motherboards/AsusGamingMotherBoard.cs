using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Motherboards
{
    public class AsusGamingMotherBoard : IComputerMotherBoard
    {
        public bool BackLight() => false;

        public int GBMaximumMemory() => 128;

        public byte MemorySlots() => 4;

        public string MemoryType() => "DDR4";

        public MotherBoardTypes MotherBoardStandard() => MotherBoardTypes.ATX;

        public string Name() => "Asus Gaming";

        public double Price() => 300;

        public Socket SocketType() => Socket.AM4;
    }
}
