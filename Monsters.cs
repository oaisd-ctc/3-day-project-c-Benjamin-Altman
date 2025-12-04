namespace CrimsonDungeonDemo
{
    public class Monsters
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }

        public Monsters(int health, int strength, int defense, int speed, int intelligence, int dexterity)
        {
            Health = health;
            Strength = strength;
            Defense = defense;
            Speed = speed;
            Intelligence = intelligence;
            Dexterity = dexterity;
        }

        public virtual void MonsterStats()
        {
            Console.WriteLine($"Health: {Health}, Strength: {Strength}, Defense: {Defense}, Speed: {Speed}, Intelligence: {Intelligence}, Dexterity: {Dexterity}");
        }
    }
}