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

            Warrior villain = new Warrior();
            villain.Damage = 3;
            villain.HP = 6;
            villain.Level = 1;
            villain.Name = "Gob";

            hero.Greetings(villain.Name);

            hero.Attack(villain);

            villain.Attack(hero);
        }
    }
}
