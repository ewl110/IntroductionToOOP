namespace MagicDestroyers.Classes.Melee
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Weapons.Sharp;

    class Assassin
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

        public Assassin()
        {
                
        }

        public void Bleed() { }

        public void Raze() { }

        public void Survival() { }
    }
}
