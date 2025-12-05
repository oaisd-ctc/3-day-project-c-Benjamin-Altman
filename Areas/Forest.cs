namespace CrimsonDungeonDemo
{
	public class Forest : IArea
	{
		public AreaType Type => AreaType.Forest;
		public string areaName => "Forest";
		public string Description => "Dense woodlands filled with towering trees and wandering creatures.";
	}
}