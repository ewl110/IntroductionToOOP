namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Assassin : Melee, IAttack, IDefend
    {
        private readonly LeatherVest ARMOR = new LeatherVest();
        private readonly Sword WEAPON = new Sword();

        public Assassin() : this(Consts.Assassin.NAME) { }

        public Assassin(string name) : this(name, Consts.LEVEL, Consts.Assassin.HIT_POINTS) { }

        public Assassin(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.AbilityPoints = Consts.Assassin.ABILITY_POINTS;
            base.Armor = this.ARMOR;
            base.Faction = Consts.Assassin.FACTION;
            base.Weapon = this.WEAPON;
        }

        public int Bleed()
        {
            return base.Weapon.Damage;
        }

        public int Raze()
        {
            return base.Weapon.Damage + 6;
        }

        public int Survival()
        {
            return base.Armor.ArmorClass + 1;
        }

        public override int Attack()
        {
            return this.Bleed();
        }

        public override int Defend()
        {
            return this.Survival();
        }

        public override int SpecialAttack()
        {
            return this.Raze();
        }
    }
}
