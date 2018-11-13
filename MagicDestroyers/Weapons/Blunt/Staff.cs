using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE = 4;

        public Staff() : base(DEFAULT_DAMAGE) { }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
