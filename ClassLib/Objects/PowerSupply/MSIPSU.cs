using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.PowerSupply
{
    public class MSIPSU : IComputerPowerSupply
    {
        public int Power() => 700;

        public double Price() => 130;

        public string Producer() => "MSI";

        public MotherBoardTypes Standard() => MotherBoardTypes.MicroATX;
    }
}
