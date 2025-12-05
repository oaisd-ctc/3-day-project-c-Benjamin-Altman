namespace CrimsonDungeonDemo;

using CrimsonDungeonDemo;

public static class CharacterSelection 
{
	public static Character? PlayerCharacter; //stores class chosen

	public static void ChooseClass()
	{
		Console.WriteLine("Select your class:");
		Console.WriteLine("1. Warrior");
		Console.WriteLine("2. Mage");
		Console.WriteLine("3. Archer");
		Console.Write("Enter your choice (1-3): ");

		string? choice = Console.ReadLine();
		Console.Write("Enter your characters name: ");
		string? playerName = Console.ReadLine();
		switch (choice)
		{
			case "1":
				PlayerCharacter = new Warrior(playerName ?? "Unknown", "Warrior");
				break;
			case "2":
				PlayerCharacter = new Mage(playerName ?? "Unknown", "Mage");
				break;
			case "3":
				PlayerCharacter = new Archer(playerName ?? "Unknown", "Archer");
				break;
			default:
				Console.WriteLine("Invalid choice. Please try again.");
				ChooseClass(); //Recursive call for invalid input
				break;
		}

		Console.WriteLine($"You have chosen the {PlayerCharacter?.GetType().Name} class.");
		PlayerCharacter?.ClassStats();
	}
}