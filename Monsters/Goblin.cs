namespace CrimsonDungeonDemo
{
    public class Goblin : Monsters
    {
        public Goblin(string Class) : base(Class, 4, 3, 2, 6, 1, 2) { }
        
        public override void MonsterStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
    }
}