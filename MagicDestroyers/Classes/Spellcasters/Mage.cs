namespace MagicDestroyers.Classes.Spellcasters
{
    using MagicDestroyers.Armor.Cloth;
    using MagicDestroyers.Weapons.Blunt;

    class Mage
    {
        private int abilityPoints;
        private ClothRobe armor;
        private string faction;
        private int hp;
        private int level;
        private string name;
        private Staff weapon;

        public int AbilityPoints { get; set; }
        public ClothRobe Armor { get; set; }
        public string Faction { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Staff Weapon { get; set; }

        public Mage()
        {

        }

        public void ArcaneWrath() { }

        public void Firewall() { }

        public void Meditation() { }
    }
}
