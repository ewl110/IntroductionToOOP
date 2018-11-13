namespace MagicDestroyers.Characters
{
    using MagicDestroyers.Enumerations;
    using System;

    public class Character
    {
        public readonly Guid id;

        private Factions faction;
        private int hitPoints;
        private int level;
        private string name;

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
    }
}
