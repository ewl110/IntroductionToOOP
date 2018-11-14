namespace MagicDestroyers.Characters
{
    using MagicDestroyers.Armor;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons;
    using System;

    public abstract class Character : IAttack, IDefend
    {
        public readonly Guid id;

        private Armor armor;
        private Factions faction;
        private int hitPoints;
        private bool isAlive = true;
        private int level;
        private string name;
        private int score = 0;
        private Weapon weapon;


        public Armor Armor
        {
            get {
                return this.armor;
            }
            set {
                this.armor = value;
            }
        }
        public Factions Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
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
                if (value >= 0)
                {
                    this.hitPoints = value;
                }
                else
                {
                    Console.WriteLine("Hit points cannot be a negative number.");
                }
            }
        }
        public Guid Id
        {
            get
            {
                return this.id;
            }
        }
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            private set
            {
                this.isAlive = value;
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
                    Console.WriteLine("Level must be between 1 - 100.");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Character names must be between 2 - 10 characters long.");
                }
            }
        }
        public int Score
        {
            get
            {
                return this.score;
            }
            private set
            {
                this.score += value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        protected Character()
        {
            this.id = this.createGuid();
        }

        protected Character(string name)
        {
            this.id = this.createGuid();
        }

        protected Character(string name, int level, int hitPoints)
        {
            this.id = this.createGuid();

            this.HitPoints = hitPoints;
            this.Level = level;
            this.Name = name;
        }

        public Guid createGuid()
        {
            Guid id = Guid.Empty;

            if (id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }

            return id;
        }

        public abstract int Attack();

        public abstract int Defend();

        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.hitPoints = this.hitPoints - damage - this.Defend();

                if (this.hitPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName} and is now dead!");
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName}, and now has {this.hitPoints}");
            }
        }

        public void WonBattle()
        {
            this.score++;

            if (this.score % 10 == 0)
            {
                this.level++;
            }
        }
    }
}