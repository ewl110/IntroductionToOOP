using System;
using IntroductionToOOP.Characters.Melee;

namespace IntroductionToOOP
{
    class Program
    {
        static void Main()
        {
            Warrior hero = new Warrior("Bob");
            Warrior villain = new Warrior("Gob");

            Console.WriteLine(hero.Id);
            Console.WriteLine(villain.Id);

            Warrior.GetAllDefaultInformation();

            hero.Greetings(villain.Name);
            hero.Attack(villain);
            villain.Attack(hero);
        }
    }
}
