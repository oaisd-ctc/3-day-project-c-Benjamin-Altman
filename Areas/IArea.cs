namespace CrimsonDungeonDemo
{
    public enum AreaType
    {
        Forest,
        Mountains,
        Plains,
        Village
    }

    public interface IArea
    {
        AreaType Type { get; }
        string areaName { get; }
        string Description { get; }
    }
}
