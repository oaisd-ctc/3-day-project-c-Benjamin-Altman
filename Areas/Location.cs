namespace CrimsonDungeonDemo
{
	public class Location
	{
		public IArea? SelectedArea { get; private set; }

		public AreaType SelectedAreaType => SelectedArea != null ? SelectedArea.Type : AreaType.Forest;

		public void SelectArea(AreaType areaType)
		{
			SelectedArea = areaType switch
			{
				AreaType.Forest => new Forest(),
				AreaType.Mountains => new Mountains(),
				AreaType.Plains => new Plains(),
				AreaType.Village => new Village(),
				_ => null
			};
		}

		public bool IsSelected(AreaType areaType) => SelectedArea != null && SelectedArea.Type == areaType;
	}
}