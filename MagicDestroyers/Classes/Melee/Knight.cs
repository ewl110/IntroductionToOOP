namespace MagicDestroyers.Classes.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Knight
    {
        private int abilityPoints;
        private Chainlink armor;
        private string faction;
        private int hitPoints;
        private int level;
        private string name;
        private Hammer weapon;

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
        public Chainlink Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value.ToLower() == "melee" || value.ToLower() == "spellcasters")
                {
                    this.faction = value;
                }
                else
                {
                    Console.WriteLine("You must choose the \"Melee\" or \"Spellcasters\" faction.");
                }
            }
        }
        public int HitPoints
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.hitPoints = value;
                }
                else
                {
                    Console.WriteLine("Hit points cannot be a negative number.");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Level must be between 1 - 100.");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Character names must be between 2 - 10 characters long.");
                }
            }
        }
        public Hammer Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Knight(string name, int level = 1, int hitPoints = 10)
        {
            this.AbilityPoints = 2;
            this.Armor = new Chainlink();
            this.Faction = "Melee";
            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
            this.Weapon = new Hammer();
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
