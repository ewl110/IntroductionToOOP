﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armor.Leather
{
    abstract class Leather : Armor
    {
        protected Leather(int armorClass) : base(armorClass) { }
    }
}
