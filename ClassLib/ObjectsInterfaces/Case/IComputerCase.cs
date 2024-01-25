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

        List<MotherBoardTypes> MotherBoardStandard();

        int[] Dimensions(); //Height.Width.Depth in mm

        int Weight(); 

        string Color();

        string Name();

        string Material();
    }
}
