﻿namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Cloth;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Mage : Spellcasters
    {
        private const int DEFAULT_MANAPOINTS = 20;
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
        private const int DEFAULT_HITPOINTS = 6;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Margeary";
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private ClothRobe armor;
        private Staff weapon;

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

        public Mage(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            this.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANAPOINTS;
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
