using System;

namespace MagicDestroyers
{
    using MagicDestroyers.Characters.Melee;
    using MagicDestroyers.Characters.Spellcasters;

    class Program
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Steven");
            Console.WriteLine(
                $"Name: {warrior.Name} \nLevel: {warrior.Level} \nHP: {warrior.HitPoints} \nAbility Points: {warrior.AbilityPoints} \nArmor: {warrior.Armor.ArmorClass} \nWeapon: {warrior.Weapon.Damage}"
            );
            //int warriorDamage = warrior.Weapon.Damage;
            Console.WriteLine();
            Druid druid = new Druid();
            Console.WriteLine(
                $"Name: {druid.Name} \nLevel: {druid.Level} \nHP: {druid.HitPoints} \nMana Points: {druid.ManaPoints} \nArmor: {druid.Armor.ArmorClass} \nWeapon: {druid.Weapon.Damage}"
            );
        }
    }
}
