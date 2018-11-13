using System;

namespace MagicDestroyers.Weapons.Sharp
{
    class Sword
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

        public Sword()
        {

        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
