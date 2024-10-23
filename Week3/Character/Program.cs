using System;
//braden shnaufer
//michelle berthiaume
class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Character(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack(Enemy enemy)
    {
        enemy.Health -= AttackPower;
        Console.WriteLine($"{Name} attacks {enemy.Name} for {AttackPower} damage!");
    }
}

class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Enemy(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack(Character character)
    {
        character.Health -= AttackPower;
        Console.WriteLine($"{Name} attacks {character.Name} for {AttackPower} damage!");
    }

void Battle(Character character, Enemy enemy)
{
    Console.WriteLine("The battle begins!");

    while (character.Health > 0 && enemy.Health > 0)
    {
        // Character attacks first
        character.Attack(enemy);
        if (enemy.Health <= 0)
        {
            Console.WriteLine($"{enemy.Name} has been defeated!");
            break;
        }

        // Enemy attacks
        enemy.Attack(character);
        if (character.Health <= 0)
        {
            Console.WriteLine($"{character.Name} has been defeated!");
            break;
        }

        Console.WriteLine($"{character.Name}'s health: {character.Health}");
        Console.WriteLine($"{enemy.Name}'s health: {enemy.Health}");
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character("Hero", 50, 10);
            Enemy goblin = new Enemy("Goblin", 30, 5);

            Battle(hero, goblin);
        }

        static void Battle(Character character, Enemy enemy)
        {
            Console.WriteLine("The battle begins!");

            while (character.Health > 0 && enemy.Health > 0)
            {
                character.Attack(enemy);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Name} has been defeated!");
                    break;
                }

                enemy.Attack(character);
                if (character.Health <= 0)
                {
                    Console.WriteLine($"{character.Name} has been defeated!");
                    break;
                }

                Console.WriteLine($"{character.Name}'s health: {character.Health}");
                Console.WriteLine($"{enemy.Name}'s health: {enemy.Health}");
            }
        }
    }

} 