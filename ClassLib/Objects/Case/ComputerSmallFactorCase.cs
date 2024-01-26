using ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Case
{
    public class ComputerSmallFactorCase : IComputerCase
    {
        public CaseSize CaseType() => CaseSize.SmallFormFactor;

        public string Color() => "White";

        public int[] Dimensions()
        {
            int[] dimensions = new int[3];
            dimensions[0] = 200;
            dimensions[1] = 120;
            dimensions[2] = 150;
            return dimensions;
        }

        public string Material() => "Metal";

        public List<MotherBoardTypes> MotherBoardStandard()
        {
            List<MotherBoardTypes> motherBoardTypes = new List<MotherBoardTypes>();
            motherBoardTypes.Add(MotherBoardTypes.MiniATX);
            return motherBoardTypes;
        }

        public string Name() => "HTPC Case";

        public double Price() => 99.99;

        public int Weight() => 1;
    }
}
