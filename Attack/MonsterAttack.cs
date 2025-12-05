namespace CrimsonDungeonDemo
{
    public class MonsterAttack : Character
    {
        public MonsterAttack(string name, string characterClass, int health, int strength, int defense, int speed = 10, int intelligence = 10, int dexterity = 10) : base(name, characterClass, health, strength, defense, speed, intelligence, dexterity)
        {
        }

        public int Damage(int strength)
        {
            return strength * 2;
        }
        public int BaseHealth(int health)
        {
            return health * 5;
        }
    }
}