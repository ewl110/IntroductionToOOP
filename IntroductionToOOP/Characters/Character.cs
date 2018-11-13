using IntroductionToOOP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToOOP.Characters
{
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
                this.hitPoints = value;
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
                    Console.WriteLine("Level must be between 1 and 100. Default level of 1 was set.");
                    level = 1;
                    // throw new ArgumentOutOfRangeException(string.Empty, "Level must be between 1 and 100. Default level of 1 was set.");
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
                this.name = value;
            }
        }

        public Character()
        {
            Guid id = Guid.Empty;

            if (id == Guid.Empty)
            {
                this.id = Guid.NewGuid();
            }
        }
    }
}
