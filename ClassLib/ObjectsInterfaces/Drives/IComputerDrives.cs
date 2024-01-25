using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Drives
{
    public interface IComputerDrives
    {
        string DiskType(); //hdd or ssd

        int GBDiskSize(); //size in gb

        int Speed();

        double Price();

        string Producer();
    }
}
