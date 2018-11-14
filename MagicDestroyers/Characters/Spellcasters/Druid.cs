namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Druid : Spellcasters, IAttack, IDefend
    {
        private readonly LeatherVest ARMOR = new LeatherVest();
        private readonly Staff WEAPON = new Staff();

        public Druid() : this(Consts.Druid.NAME) { }

        public Druid(string name) : this(name, Consts.LEVEL, Consts.Druid.HIT_POINTS) { }

        public Druid(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.Armor = this.ARMOR;
            base.Faction = Consts.Druid.FACTION;
            base.ManaPoints = Consts.Druid.MANA_POINTS;
            base.Weapon = this.WEAPON;
        }

        public int Moonfire()
        {
            return base.Weapon.Damage;
        }

        public int OneWithNature()
        {
            return base.Armor.ArmorClass + 2;
        }

        public int Starburst()
        {
            return base.Weapon.Damage + 3;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int Defend()
        {
            return this.OneWithNature();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }
    }
}
