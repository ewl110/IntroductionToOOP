using System;

namespace MagicDestroyers.Weapons.Sharp
{
    class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE = 6;

        public Sword() : base(DEFAULT_DAMAGE) { }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
