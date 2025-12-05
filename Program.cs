using System;
using System.Collections.Generic;
using System.Linq;

namespace CrimsonDungeonDemo;

public class ClassOutputTest
{
	public static void Main(string[] args)
	{
		selectArea();
		CharacterSelection.ChooseClass();
	}

	public static void selectArea()
	{
		List<string> areas = new List<string> { "Forest", "Mountains", "Plains", "Village" };
		Console.WriteLine("Select an area:");
		for (int i = 0; i < areas.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {areas[i]}");
		}

		int choice = int.Parse(Console.ReadLine() ?? "0");
		if (choice > 0 && choice <= areas.Count)
		{
			Console.WriteLine($"You selected: {areas[choice - 1]}");
		}
		else
		{
			Console.WriteLine("Invalid selection.");
		}
	}
}
