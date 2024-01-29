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
    public class ComputerBuilder : IComputerBuilder
    {
        Computer computer;

        public ComputerBuilder()
        {
            computer = new Computer();
        }

        public void buildCase(IComputerCase computerCase)
        {
            computer.Case = computerCase;
        }

        public void buildCooler(IComputerCooler cooler)
        {
            computer.Cooler = cooler;
        }

        public void buildCPU(IComputerCPU cpu)
        {
            computer.CPU = cpu;
        }

        public void buildDrive(IComputerDrives drive)
        {
            computer.Drive = drive;
        }

        public void buildGPU(IComputerGPU gpu)
        {
            computer.GPU = gpu;
        }

        public void buildKeyboard(IKeyboard keyboard)
        {
            computer.Keyboard = keyboard;
        }

        public void buildMonitor(IMonitor monitor)
        {
            computer.Monitor = monitor;
        }

        public void buildMotherBoard(IComputerMotherBoard motherBoard)
        {
            computer.MotherBoard = motherBoard;
        }

        public void buildMouse(IMouse mouse)
        {
            computer.Mouse = mouse;
        }

        public void buildPowerSupply(IComputerPowerSupply psu)
        {
            computer.PSU = psu;
        }

        public void buildRAM(IComputerRAMStick ram)
        {
            computer.RAMSticks.Add(ram);
        }

        public void buildSpeakers(ISpeakers speakers)
        {
            computer.Speaker = speakers;
        }

        public Computer GetComputer() { return computer; }
    }
}
