using IntroductionToOOP.Characters.Interfaces;
using IntroductionToOOP.Enumerations;
using IntroductionToOOP.Weapons.Sharp;
using System;
namespace IntroductionToOOP.Characters.Melee
{
    public class Warrior : Character, IDoMath
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

        private int numberA;
        private int numberB;
        public int NumberA { get => this.numberA; set => this.numberA = value; }
        public int NumberB { get => this.numberB; set => this.numberB = value; }

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

        public void AddTWoNumbers()
        {
            Console.WriteLine(this.numberA + this.numberB);
        }
    }
}