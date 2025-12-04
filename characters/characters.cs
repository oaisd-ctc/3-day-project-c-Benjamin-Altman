namespace CrimsonDungeonDemo;

public class Character
{
    public string Class { get; set;}
    public int Health { get; set;}
    public int Strength { get; set;}
    public int Defense { get; set;}
    public int Speed { get; set;}
    public int Intelligence { get; set;}
    public int Dexterity { get; set;}

    public Character(string characterClass, int health, int strength, int defense, int speed, int intelligence, int dexterity)
    {
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
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
}

public class Warrior : Character
{
    public Warrior(string Class) : base("Warrior", 13, 13, 11, 7, 6, 12) { }

    public override void ClassStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
}