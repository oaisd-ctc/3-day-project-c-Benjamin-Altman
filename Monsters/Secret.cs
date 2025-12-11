namespace CrimsonDungeonDemo
{
    public class Secret : Monsters
    {
        public Secret(string Class) : base(Class, 999999999, 999999999, 999999999, 999999999, 999999999, 999999999) { }
        
        public override void MonsterStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
    }
}