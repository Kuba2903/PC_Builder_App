using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Case
{
    public class ComputerFullTowerCase : IComputerCase
    {
        public CaseSize CaseType() => CaseSize.FullTower;

        public string Color() => "Black";

        public int[] Dimensions()
        {
            int[] dimensions = new int[3];
            dimensions[0] = 513;
            dimensions[1] = 316;
            dimensions[2] = 513;
            return dimensions;
        }

        public string Material() => "Metal";

        public List<MotherBoardTypes> MotherBoardStandard()
        {
            List<MotherBoardTypes> motherBoardTypes = new List<MotherBoardTypes>();
            motherBoardTypes.Add(MotherBoardTypes.ATX);
            motherBoardTypes.Add(MotherBoardTypes.EATX);
            return motherBoardTypes;
        }

        public string Name() => "Signum";

        public double Price() => 350;

        public int Weight() => 7;
    }
}
