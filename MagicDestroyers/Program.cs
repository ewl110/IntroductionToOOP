
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
            Warrior warrior = new Warrior("steven");
            Console.WriteLine(
               $"name: {warrior.Name} " +
               $"\nlevel: {warrior.Level} " + 
               $"\nhp: {warrior.HitPoints} " + 
               $"\nability points: {warrior.AbilityPoints} " +
               $"\narmor: {warrior.Armor.ArmorClass} " + 
               $"\nweapon: {warrior.Weapon.Damage}"
            );
            
            Console.WriteLine();
            Druid druid = new Druid();
            Console.WriteLine(
                $"name: {druid.Name} " +
                $"\nlevel: {druid.Level} " + 
                $"\nhp: {druid.HitPoints} " + 
                $"\nmana points: {druid.ManaPoints} " + 
                $"\narmor: {druid.Armor.ArmorClass} " + 
                $"\nweapon: {druid.Weapon.Damage}"
            );

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
        }
    }
}
