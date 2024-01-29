using ClassLib.Objects.CPU_s;
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
            builder.buildCase(new ComputerFullTowerCase());
            builder.buildCooler(new MasterLiquidCool());           
            builder.buildCPU(new Ryzen7CPU());
            builder.buildMotherBoard(new TomahawkMotherBoard());
            builder.buildDrive(new Samsung870SSD());
            builder.buildGPU(new RTX3050GPU());
            builder.buildKeyboard(new SteelSeriesGamingKeyboard());
            builder.buildMonitor(new Toshiba43UAMonitor());
            builder.buildMouse(new GamingMouse());
            builder.buildRAM(new CorsairRAM());
            builder.buildRAM(new CorsairRAM());
            builder.buildRAM(new CorsairRAM());
            builder.buildPowerSupply(new BeQuietPSU());
            builder.buildSpeakers(new LogitechSpeaker());

            var pc = builder.GetComputer();

            if (pc.CheckCompatibility())
                return pc;
            else
                throw new Exception();
        }


        public Computer constructMidRangeComputer(ComputerBuilder builder)
        {
            builder.buildCase(new ComputerMidTowerCase());
            builder.buildCooler(new DeepCool());
            builder.buildCPU(new I5_124CPU());
            builder.buildMotherBoard(new GigabyteGamingMotherBoard());
            builder.buildDrive(new Samsung990SSD());
            builder.buildGPU(new GTX1650GPU());
            builder.buildKeyboard(new LogitechG915Keyboard());
            builder.buildMonitor(new PhilipsMonitor());
            builder.buildMouse(new LogitechMouse());
            builder.buildRAM(new KingstonFuryRAM());
            builder.buildRAM(new KingstonFuryRAM());
            builder.buildPowerSupply(new CorsairPSU());
            builder.buildSpeakers(new LogitechSpeaker());

            var pc = builder.GetComputer();

            if(pc.CheckCompatibility())
                return pc;
            else throw new Exception();
        }


        public Computer constructLowRangeComputer(ComputerBuilder builder)
        {
            builder.buildCase(new ComputerMidTowerCase());
            builder.buildCooler(new AsusCool());
            builder.buildMotherBoard(new MSIProMotherBoard());
            builder.buildCPU(new Ryzen3CPU());
            builder.buildDrive(new SeagateHDD());
            builder.buildGPU(new RX4200GPU());
            builder.buildKeyboard(new LogitechG915Keyboard());
            builder.buildMonitor(new PhilipsMonitor());
            builder.buildMouse(new LogitechMouse());
            builder.buildRAM(new KingstonFuryRAM());
            builder.buildPowerSupply(new MSIPSU());
            builder.buildSpeakers(new LogitechSpeaker());

            var pc = builder.GetComputer();

            if (pc.CheckCompatibility())
                return pc;
            else throw new Exception();
        }
    }
}
