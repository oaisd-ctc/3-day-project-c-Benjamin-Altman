using Microsoft.Win32.SafeHandles;

namespace CrimsonDungeonDemo
{
    public class MonsterAttack : Monsters
    {
        public MonsterAttack( string monsterClass, int health, int strength, int defense, int speed = 10, int intelligence = 10, int dexterity = 10) : base( monsterClass, health, strength, defense, speed, intelligence, dexterity)
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