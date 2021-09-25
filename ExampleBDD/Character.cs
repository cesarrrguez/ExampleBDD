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
    }
}
