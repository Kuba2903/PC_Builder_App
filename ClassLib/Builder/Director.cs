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
    public class Director
    {
        public Computer constructGamingComputer(ComputerBuilder builder)
        {
            builder.buildCase(new ComputerMidTowerCase());
            builder.buildCooler(new DeepCool());           
            builder.buildCPU(new Ryzen5CPU());
            builder.buildMotherBoard(new AsusGamingMotherBoard());
            builder.buildDrive(new SeagateHDD());
            builder.buildGPU(new GTX1650GPU());
            builder.buildKeyboard(new SteelSeriesGamingKeyboard());
            builder.buildMonitor(new Toshiba43UAMonitor());
            builder.buildMouse(new GamingMouse());
            builder.buildRAM(new CorsairRAM());
            builder.buildPowerSupply(new BeQuietPSU());
            builder.buildSpeakers(new LogitechSpeaker());
            
            return builder.GetComputer();
            
        }
    }
}
