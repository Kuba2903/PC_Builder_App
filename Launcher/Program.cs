using ClassLib.Builder;

namespace Launcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ComputerBuilder builder = new ComputerBuilder();
            var computer = director.constructGamingComputer(builder);

            Console.WriteLine(computer.MotherBoard.Name());
            Console.WriteLine(computer.CPU.Model());
        }
    }
}