namespace CrimsonDungeonDemo;

public class Character
{
    public string Name { get; set;}
    public string Class { get; set;}
    public int Health { get; set;}
    public int Strength { get; set;}
    public int Defense { get; set;}
    public int Speed { get; set;}
    public int Intelligence { get; set;}
    public int Dexterity { get; set;}

    public Character(string name, string characterClass, int health, int strength, int defense, int speed, int intelligence, int dexterity)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Defense = defense;
        Speed = speed;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Class = characterClass;
    }

    public virtual void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
}

public class Warrior : Character
{
    public Warrior(string name, string Class) : base(name, Class, 13, 13, 11, 7, 6, 12) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
}
public class Mage : Character
{
    public Mage(string name, string Class) : base(name, Class, 8, 9, 6, 12, 13, 5) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
}
public class Archer : Character
{
    public Archer(string name, string Class) : base(name, Class, 6, 7, 8, 16, 11, 6) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
}