namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Warrior : Melee
    {
        private const int DEFAULT_ABILITYPOINTS = 6;
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 10;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Warren";
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private Chainlink armor;
        private Axe weapon;

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

        public Warrior(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
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
