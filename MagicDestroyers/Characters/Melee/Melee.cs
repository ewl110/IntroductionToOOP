namespace MagicDestroyers.Characters.Melee
{
    using System;

    class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value > 1)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    Console.WriteLine("Ability points must be greater than 1.");
                }
            }
        }

        protected Melee(string name, int level, int hitPoints) : base(name, level, hitPoints) {}
    }
}
