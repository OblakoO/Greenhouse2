﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Entity
{
    public class Device: IDevice
    {
        public Location Location { get; set; }
        public bool I_O { get; set; }
    }
}
