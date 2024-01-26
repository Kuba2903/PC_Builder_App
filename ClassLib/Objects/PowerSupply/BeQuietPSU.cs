using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.PowerSupply
{
    public class BeQuietPSU : IComputerPowerSupply
    {
        public int Power() => 1200;

        public double Price() => 199.99;

        public string Producer() => "Be Quiet";

        public MotherBoardTypes Standard() => MotherBoardTypes.EATX;
    }
}
