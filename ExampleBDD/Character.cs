namespace ExampleBDD
{
    public class Character
    {
        public int Health { get; set; }
        public int Level { get; set; }

        public bool IsAlive => Health > 0;

        public Character()
        {
            Health = 1000;
            Level = 1;
        }

        public void Attack(Character target, int attackDamage)
        {
            target.ReceiveAttack(attackDamage);
        }

        private void ReceiveAttack(int attackDamage)
        {
            Health -= attackDamage;
            if (Health < 0) Health = 0;
        }
    }
}
