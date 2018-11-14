using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armor.Cloth
{
    abstract class Cloth : Armor
    {
        protected Cloth(int armorClass) : base(armorClass) { }
    }
}
