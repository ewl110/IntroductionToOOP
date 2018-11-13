using System;

namespace MagicDestroyers.Armor.Leather
{
    class LeatherVest
    {
        private int armorClass;

        public int ArmorClass
        {
            get
            {
                return armorClass;
            }
            set
            {
                if (value > 1)
                {
                    armorClass = value;
                }
                else
                {
                    Console.WriteLine("Armor must be greater than 1.");
                }
            }
        }

        public LeatherVest()
        {

        }
    }
}
