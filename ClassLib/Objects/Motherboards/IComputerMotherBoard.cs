using ClassLib.Enums;
using ClassLib.ObjectsInterfaces.CPU_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Motherboards
{
    public interface IComputerMotherBoard
    {
        string Name();

        double Price();

        MotherBoardTypes MotherBoardStandard();

        Socket SocketType();

        int GBMaximumMemory(); // Set's the maximum allowed RAM memory in gb

        string MemoryType();

        byte MemorySlots();

        bool BackLight();
    }
}
