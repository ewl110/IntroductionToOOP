using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Hammer : Blunt
    {
        private const int DEFAULT_DAMAGE = 6;

        private int damage;

        public Hammer() : base(DEFAULT_DAMAGE) { }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
