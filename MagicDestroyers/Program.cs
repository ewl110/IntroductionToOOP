
namespace MagicDestroyers
{
    using System;
    using MagicDestroyers.Characters;
    using MagicDestroyers.Characters.Melee;
    using MagicDestroyers.Characters.Spellcasters;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            //Warrior warrior = new Warrior("steven");
            //Console.WriteLine(
            //   $"name: {warrior.Name} " +
            //   $"\nlevel: {warrior.Level} " + 
            //   $"\nhp: {warrior.HitPoints} " + 
            //   $"\nability points: {warrior.AbilityPoints} " +
            //   $"\narmor: {warrior.Armor.ArmorClass} " + 
            //   $"\nweapon: {warrior.Weapon.Damage}"
            //);

            //Console.WriteLine();
            //Druid druid = new Druid();
            //Console.WriteLine(
            //    $"name: {druid.Name} " +
            //    $"\nlevel: {druid.Level} " + 
            //    $"\nhp: {druid.HitPoints} " + 
            //    $"\nmana points: {druid.ManaPoints} " + 
            //    $"\narmor: {druid.Armor.ArmorClass} " + 
            //    $"\nweapon: {druid.Weapon.Damage}"
            //);

            //Character assassin = new Assassin();
            //Character druid = new Druid();
            //Character knight = new Knight();
            //Character mage = new Mage();
            //Character necromancer = new Necromancer();
            //Character warrior = new Warrior();

            //List<Character> meleeTeam = new List<Character>();
            //meleeTeam.Add(assassin);
            //meleeTeam.Add(knight);
            //meleeTeam.Add(warrior);

            //List<Character> spellTeam = new List<Character>();
            //spellTeam.Add(druid);
            //spellTeam.Add(mage);
            //spellTeam.Add(necromancer);

            Melee currentMelee;
            Spellcasters currentSpellcaster;
            bool gameOver = false;
            Random rng = new Random();

            List<Character> Characters = new List<Character>()
            {
                new Assassin(),
                new Druid(),
                new Knight(),
                new Mage(),
                new Necromancer(),
                new Warrior()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcasters> spellTeam = new List<Spellcasters>();

            foreach (var character in Characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcasters)
                {
                    spellTeam.Add((Spellcasters)character);
                }
            }

            while (!gameOver)
            {
                //1. Take a random melee
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];

                //2. Take a random spellcaster
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                //3. Melee attack spellcaster
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                //3.1 Check if character is dead and remove from team
                //3.2 If dead, get another random character
                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee Team Wins!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                    }
                }

                //4. Spellcaster Attacks Melee
                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());
                //4.1 Check if character is dead and remove from team
                //4.2 If dead, get another random character
                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spell Team Wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }

                //5. If no character are alive from either team - gameOver = true
            }
        }
    }
}
