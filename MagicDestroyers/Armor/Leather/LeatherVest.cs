using System;

namespace MagicDestroyers.Armor.Leather
{
    class LeatherVest : Leather
    {
        private const int DEFAULT_ARMORCLASS = 11;

        public LeatherVest()
        {
            this.ArmorClass = DEFAULT_ARMORCLASS;
        }
    }
}
