namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    internal class Warrior : Melee, IAttack, IDefend
    {
        public readonly Chainlink ARMOR = new Chainlink();
        public readonly Axe WEAPON = new Axe();

        public Warrior() : this(Consts.Warrior.NAME) { }

        public Warrior(string name) : this(name, Consts.LEVEL, Consts.Warrior.HIT_POINTS) { }

        public Warrior(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.Armor = this.ARMOR;
            base.Faction = Consts.Warrior.FACTION;
            base.Weapon = this.WEAPON;
        }

        public int Execute()
        {
            return base.Weapon.Damage + 2;
        }

        public int SkinHarden()
        {
            return base.Armor.ArmorClass + 1;
        }

        public int Strike()
        {
            return base.Weapon.Damage + 1;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}
