﻿namespace MagicDestroyers.Classes.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Weapons.Blunt;

    class Knight
    {
        private int abilityPoints;
        private Chainlink armor;
        private string faction;
        private int hp;
        private int level;
        private string name;
        private Hammer weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                abilityPoints = value;
            }
        }
        public Chainlink Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        }
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Hammer Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Knight()
        {

        }

        public void HolyBlow() { }

        public void PurifySoul() { }

        public void RighteousWings() { }
    }
}
