namespace MagicDestroyers.Characters
    .Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    class Knight : Melee
    {
        private const int DEFAULT_ABILITYPOINTS = 2;
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private const int DEFAULT_HITPOINTS = 10;
        private const int DEFAULT_LEVEL = 1;
        private const string DEFAULT_NAME = "Keira";
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        private Chainlink armor;
        private Hammer weapon;

        public Chainlink Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        public Hammer Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Knight() : this(DEFAULT_NAME) { }

        public Knight(string name) : this(name, DEFAULT_LEVEL, DEFAULT_HITPOINTS) { }

        public Knight(string name, int level, int hitPoints)
        {
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Armor = DEFAULT_ARMOR;
            this.Faction = DEFAULT_FACTION;
            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
            this.Weapon = DEFAULT_WEAPON;
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
    }
}
