using System;
    
    public class Warrior
{
    private int damage;
    private int hp;
    private int level;
    private string name;

    public int Damage { get; set; }
    public int HP { get; set; }
    public int Level { get; set; }
    public string Name { get; set; }

    public Warrior( string name = "Warren", int hp = 100, int damage = 10 )
    {
        Damage = damage;
        HP = hp;
        Name = name;
    }

    public void Greetings(string name) {
        Console.WriteLine($"{Name} greets {name}.");
    }

    public void Attack(Warrior enemy) {
        enemy.HP -= Damage;
        Console.WriteLine($"{Name} is attacking {enemy.Name}. {enemy.Name} now has {enemy.HP} HP remaining.");
    }
}