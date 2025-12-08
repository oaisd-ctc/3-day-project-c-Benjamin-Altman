namespace CrimsonDungeonDemo;

public class Character
{
    public int HP { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Defense { get; set; }

    public Character(string name, string characterClass, int health, int strength, int defense)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Defense = defense;
        Class = characterClass;
    }

    public virtual void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, HP: {HP}, Strength: {Strength}, Defense: {Defense}");
    }
}

public class Warrior : Character
{
    public Warrior(string name, string Class) : base(name, Class, 75, 13, 11) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, HP: {HP}, Strength: {Strength}, Defense: {Defense}");
    }
}
public class Mage : Character
{
    public Mage(string name, string Class) : base(name, Class, 35, 9, 6) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, HP: {HP}, Strength: {Strength}, Defense: {Defense}");
    }
}
public class Archer : Character
{
    public Archer(string name, string Class) : base(name, Class, 25, 7, 8) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, HP: {HP}, Strength: {Strength}, Defense: {Defense}");
    }
}