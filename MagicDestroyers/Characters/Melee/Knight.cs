﻿namespace MagicDestroyers.Characters
    .Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Knight : Melee, IAttack, IDefend
    {
        private const int DEFAULT_ABILITYPOINTS = 2;
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 10;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Keira";
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Knight() : this(DEFAULT_NAME) { }

        public Knight(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Knight(string name, int level, int hitPoints) : base(name, level, hitPoints)
        {
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Faction = DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.HolyBlow();
        }

        public override void SpecialAttack()
        {
            this.PurifySoul();
        }

        public override void Defend()
        {
            this.RighteousWings();
        }
    }
}
