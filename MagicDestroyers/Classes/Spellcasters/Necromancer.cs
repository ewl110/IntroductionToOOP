namespace MagicDestroyers.Classes.Spellcasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    class Necromancer
    {
        private int abilityPoints;
        private LeatherVest armor;
        private string faction;
        private int hitPoints;
        private int level;
        private string name;
        private Sword weapon;

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
        public LeatherVest Armor
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
        public Sword Weapon
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

        public Necromancer()
        {

        }

        public void BoneShield() { }

        public void ShadowRage() { }

        public void VampireTouch() { }
    }
}
