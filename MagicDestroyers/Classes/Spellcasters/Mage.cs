namespace MagicDestroyers.Classes.Spellcasters
{
    using MagicDestroyers.Armor.Cloth;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Mage
    {
        private const int DEFAULT_ABILITYPOINTS = 20;
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private const string DEFAULT_FACTION = "Spellcasters";
        private const int DEFAULT_HITPOINTS = 6;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Margeary";
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private int abilityPoints;
        private ClothRobe armor;
        private string faction;
        private int hitPoints;
        private int level;
        private string name;
        private Staff weapon;

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
        public ClothRobe Armor
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
                return this.faction;
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
        public Staff Weapon
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

        public Mage() : this(DEFAULT_NAME) { }

        public Mage(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Mage(string name, int level, int hitPoint)
        {
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Fireball()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
