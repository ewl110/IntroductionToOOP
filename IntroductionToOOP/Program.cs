using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToOOP
{
    class Program
    {
        static void Main()
        {
            Warrior hero = new Warrior();
            hero.Damage = 6;
            hero.HP = 12;
            hero.Level = 1;
            hero.Name = "Greg";

            Wizard villain = new Wizard();
            villain.damage = 3;
            villain.hp = 6;
            villain.level = 1;
            villain.name = "Gob";
        }
    }
}
