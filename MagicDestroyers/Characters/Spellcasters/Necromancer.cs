namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Necromancer : Spellcasters, IAttack, IDefend
    {
        private const int DEFAULT_MANAPOINTS = 14;
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
        private const int DEFAULT_HITPOINTS = 8;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Nathaniel";
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer() : this(DEFAULT_NAME) { }

        public Necromancer(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Necromancer(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANAPOINTS;
            base.Weapon = DEFAULT_WEAPON;
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

        public override void Attack()
        {
            this.ShadowRage();
        }

        public override void Defend()
        {
            this.BoneShield();
        }

        public override void SpecialAttack()
        {
            this.VampireTouch();
        }
    }
}
