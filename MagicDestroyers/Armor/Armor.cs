using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armor
{
    class Armor
    {
        private int armorClass;

        public int ArmorClass
        {
            get
            {
                return this.armorClass;
            }
            set
            {
                if (value > 1)
                {
                    this.armorClass = value;
                }
                else
                {
                    Console.WriteLine("Armor must be greater than 1.");
                }
            }
        }
    }
}
