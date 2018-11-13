namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Necromancer : Spellcasters
    {
        private const int DEFAULT_MANAPOINTS = 14;
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
        private const int DEFAULT_HITPOINTS = 8;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Nathaniel";
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

        public Necromancer() : this(DEFAULT_NAME) { }

        public Necromancer(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Necromancer(string name, int level, int hitPoints)
        {
            this.ManaPoints = DEFAULT_MANAPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }
    }
}
