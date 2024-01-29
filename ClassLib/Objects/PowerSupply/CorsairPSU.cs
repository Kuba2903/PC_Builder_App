using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.PowerSupply
{
    public class CorsairPSU : IComputerPowerSupply
    {
        public int Power() => 1000;

        public double Price() => 179.99;

        public string Producer() => "Corsair";

        public MotherBoardTypes Standard() => MotherBoardTypes.ATX;
    }
}
