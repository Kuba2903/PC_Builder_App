using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.PowerSupply
{
    public class ACCUPSU : IComputerPowerSupply
    {
        public int Power() => 550;

        public double Price() => 90;

        public string Producer() => "ACCU";

        public MotherBoardTypes Standard() => MotherBoardTypes.MiniATX;
    }
}
