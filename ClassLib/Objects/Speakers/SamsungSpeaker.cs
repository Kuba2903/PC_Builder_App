﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ObjectsInterfaces.Speakers
{
    public class SamsungSpeaker : ISpeakers
    {
        public double Price() => 49.99;

        public string Producer() => "Samsung";

        public bool Wireless() => true;
    }
}
