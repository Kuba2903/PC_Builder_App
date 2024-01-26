using ClassLib.Enums;
using ClassLib.ObjectsInterfaces.Motherboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.PowerSupply
{
    public interface IComputerPowerSupply
    {
        MotherBoardTypes Standard();

        int Power();

        string Producer();

        double Price();
    }
}
