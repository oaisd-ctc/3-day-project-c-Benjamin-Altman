namespace CrimsonDungeonDemo
{
	public class Plains : IArea
	{
		public AreaType Type => AreaType.Plains;
		public string areaName => "Plains";
		public string Description => "Wide open fields and tall grasses; easier travel but fewer places to hide.";
	}
}