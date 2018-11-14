namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armor.Cloth;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Mage : Spellcasters, IAttack, IDefend
    {
        private readonly ClothRobe ARMOR = new ClothRobe();
        private readonly Staff WEAPON = new Staff();

        public Mage() : this(Consts.Mage.NAME) { }

        public Mage(string name) : this(name, Consts.LEVEL, Consts.Mage.HIT_POINTS) { }

        public Mage(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.Armor = this.ARMOR;
            base.Faction = Consts.Mage.FACTION;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Weapon = this.WEAPON;
        }

        public int ArcaneWrath()
        {
            return 15;
        }

        public int Fireball()
        {
            return 10;
        }

        public int Meditation()
        {
            return base.Armor.ArmorClass;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
