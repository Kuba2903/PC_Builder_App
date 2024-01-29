using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Keyboards
{
    public interface IKeyboard
    {
        double Price();

        string Producer();

        bool BackLight();

        bool Wireless();
    }
}
