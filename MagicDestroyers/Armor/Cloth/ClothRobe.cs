using System;

namespace MagicDestroyers.Armor.Cloth
{
    class ClothRobe : Cloth
    {
        private const int DEFAULT_ARMORCLASS = 10;

        public ClothRobe()
        {
            this.ArmorClass = DEFAULT_ARMORCLASS;
        }
    }
}
