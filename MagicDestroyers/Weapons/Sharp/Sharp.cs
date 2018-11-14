using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Weapons.Sharp
{
    abstract class Sharp : Weapon
    {
        protected Sharp(int damage) : base(damage) { }
    }
}
