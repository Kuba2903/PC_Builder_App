using ClassLib.Builder;
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

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void CheckPrice()
        {
            Director director = new Director();
            ComputerBuilder computerBuilder = new ComputerBuilder();

            var comp = director.constructLowRangeComputer(computerBuilder);

            double ramPrice = 0;
            foreach (var x in comp.RAMSticks)
            {
                ramPrice += x.Price();
            }

            double expected = comp.PSU.Price() + comp.GPU.Price() + comp.Drive.Price() + comp.CPU.Price()
                + comp.Case.Price() + comp.Monitor.Price() + comp.Cooler.Price() + comp.Keyboard.Price()
                + comp.MotherBoard.Price() + comp.Mouse.Price() + comp.Speaker.Price() + ramPrice;

            Assert.Equal(expected,comp.GetPrice());
        }


        [Fact]

        public void CheckCompatibility_False()
        {
            ComputerBuilder builder = new ComputerBuilder();

            builder.buildCase(new ComputerSmallFactorCase());
            builder.buildCooler(new MasterLiquidCool());
            builder.buildCPU(new I7_127CPU());
            builder.buildDrive(new Samsung870SSD());
            builder.buildGPU(new GTX1650GPU());
            builder.buildKeyboard(new SteelSeriesGamingKeyboard());
            builder.buildMonitor(new Toshiba43UAMonitor());
            builder.buildMotherBoard(new TomahawkMotherBoard());
            builder.buildMouse(new GamingMouse());
            builder.buildPowerSupply(new BeQuietPSU());
            builder.buildRAM(new CorsairRAM());
            builder.buildSpeakers(new LogitechSpeaker());

            var comp = builder.GetComputer();

            bool expected = false;

            Assert.Equal(expected,comp.CheckCompatibility());
        }

        [Fact]
        public void CheckCompatibility_True()
        {
            Director director = new Director();
            ComputerBuilder builder = new ComputerBuilder();

            var comp = director.constructGamingComputer(builder);

            bool expected = true;
            
            Assert.Equal(expected,comp.CheckCompatibility());
        }
    }
}