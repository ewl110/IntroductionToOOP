namespace MagicDestroyers.Armor.Mail
{
    using System;

    class Chainlink : Mail
    {
        private const int DEFAULT_ARMORCLASS = 12;

        public Chainlink()
        {
            this.ArmorClass = DEFAULT_ARMORCLASS;
        }
    }
}
