namespace CrimsonDungeonDemo
{
    public class Skeleton : Monsters
    {
        public Skeleton(string Class) : base("Skeleton", 8, 12, 4, 3, 5, 8) { }

        public override void MonsterStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
    }
}