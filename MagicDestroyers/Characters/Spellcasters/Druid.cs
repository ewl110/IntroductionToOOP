namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Druid : Spellcasters
    {
        private const int DEFAULT_MANAPOINTS = 10;
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
        private const int DEFAULT_HITPOINTS = 8;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Diana";
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LeatherVest armor;
        private Staff weapon;

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

        public Druid() : this(DEFAULT_NAME) { }

        public Druid(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Druid(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            this.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANAPOINTS;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void OneWithNature()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }
    }
}
