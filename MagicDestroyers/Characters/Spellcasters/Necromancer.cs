namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Necromancer : Spellcasters, IAttack, IDefend
    {
        private readonly LeatherVest ARMOR = new LeatherVest();
        private readonly Sword WEAPON = new Sword();

        public Necromancer() : this(Consts.Necromancer.NAME) { }

        public Necromancer(string name) : this(name, Consts.LEVEL, Consts.Necromancer.HIT_POINTS) { }

        public Necromancer(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.Armor = this.ARMOR;
            base.Faction = Consts.Necromancer.FACTION;
            base.ManaPoints = Consts.Necromancer.MANA_POINTS;
            base.Weapon = this.WEAPON;
        }

        public int BoneShield()
        {
            return base.Armor.ArmorClass + 2;
        }

        public int ShadowRage()
        {
            return base.Weapon.Damage + 1;
        }

        public int VampireTouch()
        {
            return base.Weapon.Damage + 4;
        }

        public override int Attack()
        {
            return base.Weapon.Damage + 10;
        }

        public override int Defend()
        {
            return this.BoneShield();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }
    }
}
