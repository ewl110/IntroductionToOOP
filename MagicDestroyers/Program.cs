using System;

namespace MagicDestroyers
{
    using MagicDestroyers.Classes.Melee;

    class Program
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Steven");
            Console.WriteLine(
                $"Name: {warrior.Name} \nLevel: {warrior.Level} \nHP: {warrior.HitPoints} \nArmor: {warrior.Armor.ArmorClass} \nWeapon: {warrior.Weapon.Damage}"
            );
            //int warriorDamage = warrior.Weapon.Damage;
        }
    }
}
