namespace CrimsonDungeonDemo
{
    public class Slime : Monsters
    {

        public Slime(string Class) : base(Class, 60, 2, 2, 2, 2, 2) { }


        public override void MonsterStats()
    {
        Console.WriteLine($"Class: {Class}, Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
    }
    }
}