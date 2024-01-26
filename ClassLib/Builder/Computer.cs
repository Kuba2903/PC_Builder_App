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
    public class Computer
    {
        public IComputerCase Case { get; set; }

        public IComputerCooler Cooler { get; set; }

        public IComputerCPU CPU { get; set; }

        public IComputerDrives Drive { get; set; }

        public IComputerGPU GPU { get; set; }

        public IComputerMotherBoard MotherBoard { get; set; }

        public IKeyboard Keyboard { get; set; }

        public IMonitor Monitor { get; set; }

        public IMouse Mouse { get; set; }

        public IComputerPowerSupply PSU { get; set; }

        public List<IComputerRAMStick> RAMSticks { get; set; }

        public ISpeakers Speaker { get; set; }
    }
}
