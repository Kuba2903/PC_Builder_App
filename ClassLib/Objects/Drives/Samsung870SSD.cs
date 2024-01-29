using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Drives
{
    public class Samsung870SSD : IComputerDrives
    {
        public string DiskType() => "SSD";

        public int GBDiskSize() => 2000;

        public double Price() => 199.99;

        public string Producer() => "Samsung";

        public int Speed() => 1000;
    }
}
