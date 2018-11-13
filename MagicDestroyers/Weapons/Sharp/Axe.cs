using System;

namespace MagicDestroyers.Weapons.Sharp
{
    class Axe
    {
        private const int DEFAULT_DAMAGE = 8;

        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    Console.WriteLine("Damage cannont be zero or negative.");
                }
            }
        }

        public Axe()
        {
            this.Damage = DEFAULT_DAMAGE;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
