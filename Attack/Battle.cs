namespace CrimsonDungeonDemo
{
    public static class Battle
    {
        private static Random _random = new Random();

        public static void StartBattle(Character player, Monsters monster)
        {
            Console.WriteLine("Battle starts!");
            while (player.IsAlive && monster.Health > 0)
            {
                // Player turn
                Console.WriteLine("Your turn. Press enter to attack.");
                Console.ReadLine();
                int playerDamage = player.Damage() + _random.Next(0, 6) - monster.Defense;
                if (playerDamage < 1) playerDamage = 1;
                monster.Health -= playerDamage;
                Console.WriteLine($"You deal {playerDamage} damage. Monster health: {monster.Health}");

                

                // Monster turn
                Console.WriteLine("Monster's turn.");
                int monsterDamage = monster.Strength + _random.Next(15, 20) - player.Defense;
                if (monsterDamage < 1) monsterDamage = 1;
                player.TakeDamage(monsterDamage);
                Console.WriteLine($"Monster deals {monsterDamage} damage. Your HP: {player.HP}");

                if (!player.IsAlive)
                {
                    Console.WriteLine("You lose!");
                    return;
                }
                if (monster.Health <= 0)
                {
                    Console.WriteLine("You win the battle!");
                    Console.WriteLine("A new monster appears!");
                    return;
                }

            }
        }
    }
}