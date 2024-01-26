using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Drives
{
    public class Samsung990SSD : IComputerDrives
    {
        public string DiskType() => "SSD";

        public int GBDiskSize() => 1000;

        public double Price() => 129.99;

        public string Producer() => "Samsung";

        public int Speed() => 850;
    }
}
