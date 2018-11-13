using System;
using IntroductionToOOP.Characters.Melee;

namespace IntroductionToOOP
{
    class Program
    {
        static void Main()
        {
            Warrior hero = new Warrior("Bob", 70, 12);
            Warrior villain = new Warrior("Gob", 100, 6);

            hero.Greetings(villain.Name);
            hero.Attack(villain);
            villain.Attack(hero);
        }
    }
}
