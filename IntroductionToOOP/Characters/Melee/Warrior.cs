using IntroductionToOOP.Weapons.Sharp;
using System;
namespace IntroductionToOOP.Characters.Melee
{
    public class Warrior
    {
        private const int DEFAULT_HITPOINTS =100;
        private const string DEFAULT_NAME = "Warren";

        public readonly Guid id;

        private int hitPoints;
        private int level;
        private string name;
        private Sword weapon;

        public int HitPoints
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                this.hitPoints = value;
            }
        }
        public Guid Id {
            get {
                return this.id;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Level must be between 1 and 100. Default level of 1 was set.");
                    level = 1;
                    // throw new ArgumentOutOfRangeException(string.Empty, "Level must be between 1 and 100. Default level of 1 was set.");
                }
            }
        }
        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

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
            Guid id = Guid.Empty;

            if (id == Guid.Empty)
            {
                this.id = Guid.NewGuid();
            }

            this.HitPoints = hitPoints;
            this.Name = name;
            this.Weapon = new Sword();
        }

        public void Greetings(string name)
        {
            Console.WriteLine($"{this.name} greets {name}.");
        }

        public void Attack(Warrior enemy)
        {
            enemy.HitPoints -= this.weapon.Damage;
            Console.WriteLine($"{this.name} is attacking {enemy.Name}. {this.name} does {this.weapon.Damage} damage. {enemy.Name} now has {enemy.HitPoints} HP remaining.");
        }

        public void Strike(Warrior enemy)
        {
            throw new NotImplementedException();
        }
    }
}