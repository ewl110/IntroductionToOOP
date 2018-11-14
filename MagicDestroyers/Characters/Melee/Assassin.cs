namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Assassin : Melee, IAttack, IDefend
    {
        private const int DEFAULT_ABILITYPOINTS = 4;
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 8;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Adam";
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Assassin() : this(DEFAULT_NAME) { }

        public Assassin(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Assassin(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
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

        public override void Attack()
        {
            this.Bleed();
        }

        public override void Defend()
        {
            this.Survival();
        }

        public override void SpecialAttack()
        {
            this.Raze();
        }
    }
}
