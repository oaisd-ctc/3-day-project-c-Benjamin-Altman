namespace CrimsonDungeonDemo;

public class Program
{
	
	public class GoblinCs { public void DoSomething() { Console.WriteLine("You enter a battle with a goblin."); } }
	public class SkeletonCs { public void DoSomething() { Console.WriteLine("You enter a battle with a skeleton."); } }
	public class SlimeCs { public void DoSomething() { Console.WriteLine("You enter a battle with a slime."); } }
	public class SpiderCs { public void DoSomething() { Console.WriteLine("You enter a battle with a spider."); } }
	public class ZombieCs { public void DoSomething() { Console.WriteLine("You enter a battle with a zombie."); } }
	public class MonsterSelector
	{
		private static Random _random = new Random();

		public static object GetRandomMonsterInstance()
		{
			List<Type> classTypes = new List<Type>
			{
				typeof(GoblinCs),
				typeof(SkeletonCs),
				typeof(SlimeCs),
				typeof(SpiderCs),
				typeof(ZombieCs)
			};
			int randomIndex = _random.Next(0, classTypes.Count);
			Type selectedType = classTypes[randomIndex];

			return Activator.CreateInstance(selectedType);
		}

		public static void Main(string[] args)
		{
			Console.Clear();
			CharacterSelection.ChooseClass();
	
			object randomInstance = GetRandomMonsterInstance();
			if (randomInstance is GoblinCs a) a.DoSomething();
			else if (randomInstance is SkeletonCs b) b.DoSomething();
			else if (randomInstance is SlimeCs c) c.DoSomething();
			else if (randomInstance is SpiderCs d) d.DoSomething();
			else if (randomInstance is ZombieCs e) e.DoSomething();
			
			
			
		}
	}
}