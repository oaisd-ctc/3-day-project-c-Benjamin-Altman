namespace CrimsonDungeonDemo
{
	public class Village : IArea
	{
		public AreaType Type => AreaType.Village;
		public string areaName => "Village";
		public string Description => "A small settlement where travelers can rest chat and gather information.";
	}
}