using System;

namespace MagicDestroyers
{
    using MagicDestroyers.Characters.Melee;

    class Program
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Steven");
            Console.WriteLine(
                $"Name: {warrior.Name} \nLevel: {warrior.Level} \nHP: {warrior.HitPoints} \nAbility Points: {warrior.AbilityPoints} \nArmor: {warrior.Armor.ArmorClass} \nWeapon: {warrior.Weapon.Damage}"
            );
            //int warriorDamage = warrior.Weapon.Damage;
        }
    }
}
