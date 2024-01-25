using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Case
{
    public class ComputerMidTowerCase : IComputerCase
    {
        public CaseSize CaseType() => CaseSize.MidTower;

        public string Color() => "Blue";

        public int[] Dimensions()
        {
            int[] dimensions = new int[3];
            dimensions[0] = 410;
            dimensions[1] = 215;
            dimensions[2] = 410;
            return dimensions;
        }

        public string Material() => "Metal";

        public List<MotherBoardTypes> MotherBoardStandard()
        {
            List<MotherBoardTypes> motherBoardTypes = new List<MotherBoardTypes>();
            motherBoardTypes.Add(MotherBoardTypes.ATX);
            motherBoardTypes.Add(MotherBoardTypes.MicroATX);
            return motherBoardTypes;
        }

        public string Name() => "Lenovo Think Station";

        public double Price() => 319.99;

        public int Weight() => 5;
    }
}
