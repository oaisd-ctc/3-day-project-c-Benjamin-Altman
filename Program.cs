
﻿namespace CrimsonDungeonDemo;

public class Program
{
	public class MonsterSelector
	{
		private static Random _random = new Random();

		public static Monsters GetRandomMonsterInstance()
		{
			List<Monsters> monsters = new List<Monsters>
			{
				new Goblin("Goblin"),
				new Skeleton("Skeleton"),
				new Slime("Slime"),
				new Spider("Spider"),
				new Zombie("Zombie"),
				new Secret("Mr. Luyk"),
				new Secret("Mr. Martinez")
			};
			int randomIndex = _random.Next(0, monsters.Count);
			return monsters[randomIndex];
		}

		public static void Main(string[] args)
		{
			Console.Clear();
			CharacterSelection.ChooseClass();
	
			Monsters randomMonster = GetRandomMonsterInstance();
			Console.WriteLine($"You encounter a {randomMonster.Class}!");
			randomMonster.MonsterStats();
			
			Battle.StartBattle(CharacterSelection.PlayerCharacter, randomMonster);
		}
	}
}
