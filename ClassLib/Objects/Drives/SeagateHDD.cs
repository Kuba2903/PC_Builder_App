using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Drives
{
    public class SeagateHDD : IComputerDrives
    {
        public string DiskType() => "HDD";

        public int GBDiskSize() => 2000;

        public double Price() => 109.99;

        public string Producer() => "Seagate";

        public int Speed() => 7200;
    }
}
