namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Assassin : Melee
    {
        private const int DEFAULT_ABILITYPOINTS = 4;
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 8;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Adam";
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LeatherVest armor;
        private Sword weapon;

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

        public Assassin(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
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
