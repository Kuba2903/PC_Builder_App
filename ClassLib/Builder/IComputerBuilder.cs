using ClassLib.ObjectsInterfaces.Case;
using ClassLib.ObjectsInterfaces.Coolers;
using ClassLib.ObjectsInterfaces.CPU_s;
using ClassLib.ObjectsInterfaces.Drives;
using ClassLib.ObjectsInterfaces.GPU_s;
using ClassLib.ObjectsInterfaces.Keyboards;
using ClassLib.ObjectsInterfaces.Monitors;
using ClassLib.ObjectsInterfaces.Motherboards;
using ClassLib.ObjectsInterfaces.Mouse;
using ClassLib.ObjectsInterfaces.PowerSupply;
using ClassLib.ObjectsInterfaces.RAMSticks;
using ClassLib.ObjectsInterfaces.Speakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Builder
{
    public interface IComputerBuilder
    {
        void buildCase(IComputerCase computerCase);

        void buildMotherBoard(IComputerMotherBoard motherBoard);

        void buildCooler(IComputerCooler cooler);

        void buildCPU(IComputerCPU cpu);

        void buildGPU(IComputerGPU gpu);

        void buildDrive(IComputerDrives drive);

        void buildRAM(IComputerRAMStick ram);

        void buildPowerSupply(IComputerPowerSupply psu);

        void buildKeyboard(IKeyboard keyboard);

        void buildMonitor(IMonitor monitor);

        void buildMouse(IMouse mouse);

        void buildSpeakers(ISpeakers speakers);
    }
}
