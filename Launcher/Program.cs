using ClassLib.Builder;

namespace Launcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ComputerBuilder builder = new ComputerBuilder();
            
            var computer = director.constructLowRangeComputer(builder);

            
            Console.WriteLine(computer.GetPrice());
            Console.WriteLine(computer.GetShortSpecification());
        }
    }
}