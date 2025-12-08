namespace CrimsonDungeonDemo
{
    public class Player : Character
    {
        public Player(string name, string characterClass, int hp, int strength, int defense) : base(name, characterClass, hp, strength, defense)
        {
        }
        public int Damage()
        {
            return Strength * 2;
        }
        

        public void TakeDamage(int damageAmount)
        {
            HP -= damageAmount;
            if (HP < 0)
                HP = 0;
        }

        public bool IsAlive => HP > 0;
    }
}