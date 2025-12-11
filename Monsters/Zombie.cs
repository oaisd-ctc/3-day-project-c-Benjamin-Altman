namespace CrimsonDungeonDemo
{
    public class Zombie : Monsters
    {
        public Zombie(string Class) : base(Class, 115, 8, 3, 8, 2, 5) { }

        public override void MonsterStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
    }
}