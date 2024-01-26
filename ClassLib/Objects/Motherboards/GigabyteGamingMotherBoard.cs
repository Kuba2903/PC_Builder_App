using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Motherboards
{
    public class GigabyteGamingMotherBoard : IComputerMotherBoard
    {
        public bool BackLight() => true;

        public int GBMaximumMemory() => 128;

        public byte MemorySlots() => 4;

        public string MemoryType() => "DDR5";

        public MotherBoardTypes MotherBoardStandard() => MotherBoardTypes.ATX;

        public string Name() => "Gigabyte Gaming";

        public double Price() => 300.99;

        public Socket SocketType() => Socket.LGA1700;
    }
}
