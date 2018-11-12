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
            hero.damage = 6;
            hero.hp = 12;
            hero.level = 1;
            hero.name = "Greg";

            Wizard villain = new Wizard();
            villain.damage = 3;
            villain.hp = 6;
            villain.level = 1;
            villain.name = "Gob";
        }
    }
}
