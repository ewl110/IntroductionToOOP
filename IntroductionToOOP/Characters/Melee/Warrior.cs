using IntroductionToOOP.Weapons.Sharp;
using System;
namespace IntroductionToOOP.Characters.Melee
{
    public class Warrior
    {
        private int damage;
        private int hitPoints;
        private int level;
        private string name;
        private Sword weapon;

        public int Damage {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }
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
                this.Weapon = value;
            }
        }

        public Warrior(){
            this.Damage = 10;
            this.HitPoints = 100;
            this.Name = "Warren";
            this.Weapon = new Sword();
        }

        public Warrior(string name)
        {
            this.Damage = 10;
            this.HitPoints = 100;
            this.Name = name;
            this.Weapon = new Sword();
        }

        public Warrior(string name = "Warren", int hitPoints = 100, int damage = 10)
        {
            this.Damage = damage;
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
            enemy.HitPoints -= Damage;
            Console.WriteLine($"{this.name} is attacking {enemy.Name}. {this.name} does {this.damage} damage. {enemy.Name} now has {enemy.HitPoints} HP remaining.");
        }

        public void Strike(Warrior enemy)
        {
            throw new NotImplementedException();
        }
    }
}