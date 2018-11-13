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
        public ClothRobe Armor
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
        public Staff Weapon
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

        public Mage()
        {

        }

        public void ArcaneWrath() { }

        public void Firewall() { }

        public void Meditation() { }
    }
}
