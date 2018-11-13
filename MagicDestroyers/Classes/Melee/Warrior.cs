﻿namespace MagicDestroyers.Classes.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Warrior
    {
        private int abilityPoints;
        private Chainlink armor;
        private string faction;
        private int hitPoints;
        private int level;
        private string name;
        private Axe weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value > 1)
                {
                    abilityPoints = value;
                }
                else
                {
                    Console.WriteLine("Ability points must be greater than 1.");
                }
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
                if (value.ToLower() == "melee" || value.ToLower() == "spellcasters")
                {
                    faction = value;
                }
                else
                {
                    Console.WriteLine("You must choose the \"Melee\" or \"Spellcasters\" faction.");
                }
            }
        }
        public int HitPoints
        {
            get
            {
                return hitPoints;
            }
            set
            {
                if (value >= 0)
                {
                    hitPoints = value;
                }
                else
                {
                    Console.WriteLine("Hit points cannot be a negative number.");
                }
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
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Level must be between 1 - 100.");
                }
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
                if (value.Length >= 2 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Character names must be between 2 - 10 characters long.");
                }
            }
        }
        public Axe Weapon
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

        public Warrior()
        {

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
    }
}
