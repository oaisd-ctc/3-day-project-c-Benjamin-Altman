namespace CrimsonDungeonDemo
{
    public class Player : Character
    {
        public Player(string name, string characterClass, int health, int strength, int defense, int speed = 10, int intelligence = 10, int dexterity = 10) : base(name, characterClass, health, strength, defense, speed, intelligence, dexterity)
        {
        }
    }
}