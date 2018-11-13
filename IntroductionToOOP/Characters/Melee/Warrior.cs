using System;
namespace IntroductionToOOP.Characters.Melee
{
    public class Warrior
    {
        private int damage;
        private int hitPoints;
        private int level;
        private string name;

        public int Damage {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
        public int HitPoints { get; set; }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Level must be between 1 and 100. Default level of 1 was set.");
                    level = 1;
                    // throw new ArgumentOutOfRangeException(string.Empty, "Level must be between 1 and 100. Default level of 1 was set.");
                }
            }
        }
        public string Name { get; set; }

        public Warrior(string name = "Warren", int hitPoints = 100, int damage = 10)
        {
            Damage = damage;
            HitPoints = hitPoints;
            Name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine($"{Name} greets {name}.");
        }

        public void Attack(Warrior enemy)
        {
            enemy.HitPoints -= Damage;
            Console.WriteLine($"{Name} is attacking {enemy.Name}. {enemy.Name} now has {enemy.HitPoints} HP remaining.");
        }

        public void Strike(Warrior enemy)
        {
            throw new NotImplementedException();
        }
    }
}