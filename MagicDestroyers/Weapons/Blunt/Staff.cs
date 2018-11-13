using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Staff
    {
        private const int DEFAULT_DAMAGE = 4;

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

        public Staff()
        {
            this.Damage = DEFAULT_DAMAGE;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
