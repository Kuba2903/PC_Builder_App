using ClassLib.Enums;
using ClassLib.ObjectsInterfaces.Motherboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Case
{
    public interface IComputerCase
    {
        double Price();
        CaseSize CaseType();

        MotherBoardTypes MotherBoardStandard();

        string Dimensions();

        int[] Weight(); //Height.Width.Depth

        string Color();

        string Name();

        string Material();
    }
}
