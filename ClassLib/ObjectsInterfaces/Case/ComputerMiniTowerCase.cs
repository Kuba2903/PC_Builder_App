using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Case
{
    public class ComputerMiniTowerCase : IComputerCase
    {
        public CaseSize CaseType() => CaseSize.MiniTower;

        public string Color() => "Black";

        public int[] Dimensions()
        {
            int[] dimensions = new int[3];
            dimensions[0] = 311;
            dimensions[1] = 180;
            dimensions[2] = 313;
            return dimensions;
        }

        public string Material() => "Metal";

        public List<MotherBoardTypes> MotherBoardStandard()
        {
            List<MotherBoardTypes> motherBoardTypes = new List<MotherBoardTypes>();
            motherBoardTypes.Add(MotherBoardTypes.MicroATX);
            motherBoardTypes.Add(MotherBoardTypes.MiniATX);
            return motherBoardTypes;
        }

        public string Name() => "Aerocool";

        public double Price() => 199.99;

        public int Weight() => 3;
    }
}
