namespace CrimsonDungeonDemo
{
    public class Spider : Monsters
    {

        public Spider(string Class) : base(Class, 100, 9, 7, 11, 14, 5) { }

        public override void MonsterStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
    }
}