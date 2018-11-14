namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    internal class Warrior : Melee, IAttack, IDefend
    {
        private const int DEFAULT_ABILITYPOINTS = 6;
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 10;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Warren";
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public Warrior() : this(DEFAULT_NAME) { }

        public Warrior(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Warrior(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.Strike();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }
    }
}
