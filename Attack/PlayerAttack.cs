namespace CrimsonDungeonDemo
{
    public class PlayerAttack : Player
    {
        public int damage { get; set; }
        public int baseHealth { get; set; }

        public int Damage(int damage)
        {
            damage = Strength * 2;
            return damage;
        }

        public int BaseHealth(int baseHealth)
        {
            baseHealth = Health * 5;
            return baseHealth;
        }

        public void Battle()
        {
            
        }
    }
}