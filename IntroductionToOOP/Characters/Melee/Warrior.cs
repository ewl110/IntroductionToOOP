using IntroductionToOOP.Enumerations;
using IntroductionToOOP.Weapons.Sharp;
using System;
namespace IntroductionToOOP.Characters.Melee
{
    public class Warrior : Character
    {
        private const int DEFAULT_HITPOINTS = 100;
        private const string DEFAULT_NAME = "Warren";

        private Sword weapon;

        public Sword Weapon {
            get {
                return this.weapon;
            }
            set {
                this.weapon = new Sword();
            }
        }

        public Warrior() : this(DEFAULT_NAME) {}

        public Warrior(string name) : this(name, DEFAULT_HITPOINTS) {}

        public Warrior(string name, int hitPoints)
        {
            this.HitPoints = hitPoints;
            this.Name = name;
            this.Weapon = new Sword();
        }

        public void Greetings(string name)
        {
            Console.WriteLine($"{this.Name} greets {name}.");
        }

        public void Attack(Warrior enemy)
        {
            enemy.HitPoints -= this.weapon.Damage;
            Console.WriteLine($"{this.Name} is attacking {enemy.Name}. {this.Name} does {this.weapon.Damage} damage. {enemy.Name} now has {enemy.HitPoints} HP remaining.");
        }

        public void Strike(Warrior enemy)
        {
            throw new NotImplementedException();
        }

        public static void GetAllDefaultInformation()
        {
            Console.WriteLine(
                $"Default Name is: {DEFAULT_NAME}" + 
                $"\nDefault HitPoints: {DEFAULT_HITPOINTS}"
            );
        }
    }
}