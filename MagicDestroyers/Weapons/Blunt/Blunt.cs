using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Weapons.Blunt
{
    abstract class Blunt : Weapon
    {
        protected Blunt(int damage) : base(damage) { }
    }
}
