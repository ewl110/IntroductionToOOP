using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Hammer
    {
        private const int DEFAULT_DAMAGE = 6;

        private int damage;

        public int Damage {
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

        public Hammer()
        {
            this.Damage = DEFAULT_DAMAGE;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
