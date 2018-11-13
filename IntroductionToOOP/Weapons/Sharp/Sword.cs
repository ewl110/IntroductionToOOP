using System;

namespace IntroductionToOOP.Weapons.Sharp
{
    public class Sword
    {
        private int damage;

        public int Damage {
            get {
                return this.damage;
            }
            set {
                if (value >= 1 && value <= 10)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 1;
                    Console.WriteLine("Damage should be between 1 - 10.");
                }
            }
        }

        public Sword()
        {
            this.Damage = 10;
        }

        public void Bloodthirst() {
            throw new NotImplementedException();
        }
    }
}
