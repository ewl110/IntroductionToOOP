namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Cloth;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Mage : Spellcasters, IAttack, IDefend
    {
        private const int DEFAULT_MANAPOINTS = 20;
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
        private const int DEFAULT_HITPOINTS = 6;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Margeary";
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage() : this(DEFAULT_NAME) { }

        public Mage(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Mage(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANAPOINTS;
            base.Weapon = DEFAULT_WEAPON;
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

        public override void Attack()
        {
            this.Fireball();
        }

        public override void Defend()
        {
            this.Meditation();
        }

        public override void SpecialAttack()
        {
            this.ArcaneWrath();
        }
    }
}
