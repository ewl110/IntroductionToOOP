namespace MagicDestroyers.Characters
    .Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Knight : Melee, IAttack, IDefend
    {
        private readonly Chainlink ARMOR = new Chainlink();
        private readonly Hammer WEAPON = new Hammer();

        public Knight() : this(Consts.Knight.NAME) { }

        public Knight(string name) : this(name, Consts.LEVEL, Consts.Knight.HIT_POINTS) { }

        public Knight(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.AbilityPoints = Consts.Knight.ABILITY_POINTS;
            base.Armor = this.ARMOR;
            base.Faction = Consts.Knight.FACTION;
            base.Weapon = this.WEAPON;
        }

        public int HolyBlow()
        {
            return base.Weapon.Damage + 1;
        }

        public int PurifySoul()
        {
            return base.Weapon.Damage + 2;
        }

        public int RighteousWings()
        {
            return base.Armor.ArmorClass + 3;
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}
