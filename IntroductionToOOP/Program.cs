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
            Warrior hero = new Warrior("Bob");

            Warrior villain = new Warrior("Gob");

            hero.Greetings(villain.Name);

            hero.Attack(villain);

            villain.Attack(hero);
        }
    }
}
