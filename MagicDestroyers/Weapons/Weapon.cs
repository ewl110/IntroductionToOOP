namespace MagicDestroyers.Weapons
{
    using System;

    public abstract class Weapon
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

        protected Weapon(int damage) {
            this.Damage = damage;
        }
    }
}
