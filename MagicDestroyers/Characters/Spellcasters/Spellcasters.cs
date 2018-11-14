namespace MagicDestroyers.Characters.Spellcasters
{
    using System;

    abstract class Spellcasters : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value > 1)
                {
                    this.manaPoints = value;
                }
                else
                {
                    Console.WriteLine("Mana points must be greater than 1.");
                }
            }
        }

        protected Spellcasters(string name, int level, int hitPoints) : base(name, level, hitPoints) { }
    }
}
