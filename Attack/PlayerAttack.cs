namespace CrimsonDungeonDemo
{
    public class PlayerAttack : Player
    {
        public PlayerAttack(string name, string playerClass, int health, int strength, int defense) 
            : base(name, playerClass, health, strength, defense)
        {
        }

        public int Damage()
        {
            return Strength * 2;
        }

        public int BaseHealth()
        {
            return Health * 5;
        }

        public void Battle(MonsterAttack monster)
        {
            int playerDamage = Damage();
            int monsterDamage = monster.Damage(monster.Strength);
            
            Console.WriteLine($"{Name} attacks {monster.Name} for {playerDamage} damage!");
            monster.Health -= playerDamage;
            
            if (monster.Health > 0)
            {
                Console.WriteLine($"{monster.Name} attacks {Name} for {monsterDamage} damage!");
                Health -= monsterDamage;
            }
        }
    }
}