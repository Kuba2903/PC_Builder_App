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

        public Computer()
        {
            RAMSticks = new List<IComputerRAMStick>();
        }


        public bool CheckCompatibility()
        {
            if (Case.MotherBoardStandard().Contains(MotherBoard.MotherBoardStandard()))
            {
                if (MotherBoard.SocketType().Equals(CPU.SocketType()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public double GetPrice()
        {
            double price = 0;

            double ramPrice = 0;

            foreach (var x in RAMSticks)
            {
                ramPrice += x.Price();
            }

            price += Case.Price() + Cooler.Price() + CPU.Price() + Drive.Price() + GPU.Price() + 
                MotherBoard.Price() + Keyboard.Price() + Monitor.Price() + Mouse.Price() + PSU.Price()
                + Speaker.Price() + ramPrice;

            return price;
        }
    }
}
