﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace windowsForms_client.Tanks
{
    public class BlueTommyGunTank : TommyGunTank
    {
        public BlueTommyGunTank() : base() 
        {
            Color = Color.Blue;
        }

        public BlueTommyGunTank(string id, int x, int y, string name) : base(id, x, y, name)
        {
            Color = Color.Blue;
        }
    }
}
