namespace CrimsonDungeonDemo
{
	public class Mountains : IArea
	{
		public AreaType Type => AreaType.Mountains;
		public string areaName => "Mountains";
		public string Description => "Rugged peaks and cold winds; danger awaits among the crags.";
	}
}