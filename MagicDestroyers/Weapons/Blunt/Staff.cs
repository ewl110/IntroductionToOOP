using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Staff
    {
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

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
