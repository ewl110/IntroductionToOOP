using MagicDestroyers.Armor.Mail;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
    public static class Consts
    {
        public const int LEVEL = 1;
        public const int SCORE = 0;

        public static class Assassin
        {
            public const int ABILITY_POINTS = 4;
            public const Factions FACTION = Factions.Melee;
            public const int HIT_POINTS = 8;
            public const string NAME = "Adam";
        }

        public static class Druid
        {
            public const Factions FACTION = Factions.Spellcasters;
            public const int HIT_POINTS = 8;
            public const int MANA_POINTS = 10;
            public const string NAME = "Diana";
        }

        public static class Knight
        {
            public const int ABILITY_POINTS = 2;
            public const Factions FACTION = Factions.Melee;
            public const int HIT_POINTS = 10;
            public const string NAME = "Keira";
        }

        public static class Mage
        {
            public const Factions FACTION = Factions.Spellcasters;
            public const int HIT_POINTS = 6;
            public const int MANA_POINTS = 20;
            public const string NAME = "Margeary";
        }

        public static class Necromancer
        {
            public const Factions FACTION = Factions.Spellcasters;
            public const int HIT_POINTS = 8;
            public const int MANA_POINTS = 14;
            public const string NAME = "Nathaniel";
        }

        public static class Warrior
        {
            public const int ABILITY_POINTS = 6;
            public const Factions FACTION = Factions.Melee;
            public const int HIT_POINTS = 10;
            public const string NAME = "Warren";
        }
    }
}
