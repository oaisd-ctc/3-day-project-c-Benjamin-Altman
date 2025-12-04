namespace CrimsonDungeonDemo
{
    public class CrimsonDungeonDemo
    {
        private int damage;
        private int health;
        private string location;

        public CrimsonDungeonDemo(int damage, int health, string location)
        {
            this.damage = damage;
            this.health = health;
            this.location = location;
        }

        public string GetLocation()
        {
            return this.location;
        }
    }
}
