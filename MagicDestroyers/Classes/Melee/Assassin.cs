namespace MagicDestroyers.Classes.Melee
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Assassin
    {
        private const int DEFAULT_ABILITYPOINTS = 4;
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 8;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Adam";
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private int abilityPoints;
        private LeatherVest armor;
        private Factions faction;
        private int hitPoints;
        private int level;
        private string name;
        private Sword weapon;

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
        public LeatherVest Armor
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
        public Sword Weapon
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

        public Assassin() : this(DEFAULT_NAME) { }

        public Assassin(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Assassin(string name, int level, int hitPoints)
        {
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Bleed()
        {
            throw new NotImplementedException();
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
