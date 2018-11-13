using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Hammer
    {
        private int damage;

        public int Damage {
            get
            {
                return damage;
            }
            set
            {
                if (value > 0)
                {
                    damage = value;
                }
                else
                {
                    Console.WriteLine("Damage cannont be zero or negative.");
                }
            }
        }

        public Hammer()
        {

        }

        public void Stun() { }
    }
}
