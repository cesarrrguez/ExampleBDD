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

        public void Heal(Character target, int healedValue)
        {
            target.ReceiveHeal(healedValue);
        }

        private void ReceiveAttack(int attackDamage)
        {
            Health -= attackDamage;
            if (Health < 0) Health = 0;
        }

        private void ReceiveHeal(int healValue)
        {
            if (!IsAlive) return;

            Health += healValue;
            if (Health > 1000) Health = 1000;
        }
    }
}
