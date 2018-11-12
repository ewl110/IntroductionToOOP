using MagicDestroyers.Armor;
using MagicDestroyers.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Classes
{
    class Necromancer
    {
        private int abilityPoints;
        private LeatherVest armor;
        private string faction;
        private int hp;
        private int level;
        private string name;
        private Sword weapon;

        public int AbilityPoints { get; set; }
        public LeatherVest Armor { get; set; }
        public string Faction { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Sword Weapon { get; set; }
    }
}
