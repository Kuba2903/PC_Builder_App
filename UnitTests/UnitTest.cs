using ClassLib.Builder;

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
    }
}