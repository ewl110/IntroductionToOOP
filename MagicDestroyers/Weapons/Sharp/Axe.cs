using System;

namespace MagicDestroyers.Weapons.Sharp
{
    class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE = 8;

        public Axe() : base(DEFAULT_DAMAGE) { }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
