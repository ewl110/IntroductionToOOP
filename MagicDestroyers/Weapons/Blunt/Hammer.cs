﻿using System;

namespace MagicDestroyers.Weapons.Blunt
{
    class Hammer
    {
        private int damage;

        public int Damage {
            get
            {
                return this.damage;
            }
            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    Console.WriteLine("Damage cannont be zero or negative.");
                }
            }
        }

        public Hammer()
        {
            this.Damage = 6;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
