using MagicDestroyers.Armor.Leather;
using MagicDestroyers.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Classes.Spellcasters
{
    class Druid
    {
        private int abilityPoints;
        private LeatherVest armor;
        private string faction;
        private int hp;
        private int level;
        private string name;
        private Staff weapon;

        public int AbilityPoints { get; set; }
        public LeatherVest Armor { get; set; }
        public string Faction { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Staff Weapon { get; set; }

        public Druid()
        {

        }

        public void Moonfire() { }

        public void OneWithNature() { }

        public void Starburst() { }
    }
}
