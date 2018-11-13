using System;

namespace MagicDestroyers.Armor.Mail
{
    class Chainlink
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

        public Chainlink()
        {

        }
    }
}
