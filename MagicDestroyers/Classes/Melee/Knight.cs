namespace MagicDestroyers.Classes.Melee
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

        public int AbilityPoints { get; set; }
        public Chainlink Armor { get; set; }
        public string Faction { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Hammer Weapon { get; set; }

        public Knight()
        {

        }

        public void HolyBlow() { }

        public void PurifySoul() { }

        public void RighteousWings() { }
    }
}
