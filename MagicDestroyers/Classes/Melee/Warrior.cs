namespace MagicDestroyers.Classes.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Warrior
    {
        private const int DEFAULT_ABILITYPOINTS = 6;
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 10;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Warren";
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private int abilityPoints;
        private Chainlink armor;
        private Factions faction;
        private int hitPoints;
        private int level;
        private string name;
        private Axe weapon;

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
        public Factions Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
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
        public Axe Weapon
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

        public Warrior() : this(DEFAULT_NAME) { }

        public Warrior(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Warrior(string name, int level, int hitPoints)
        {
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }
    }
}
