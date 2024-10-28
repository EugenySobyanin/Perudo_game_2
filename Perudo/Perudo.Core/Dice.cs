namespace Perudo.Core
{
    public class Dice
    {
        public int Value { get; set; }
        public Random random = new Random();
        public Dice() { }
        public void Shake()
        {
            Value = random.Next(1, 7);
        }
    }
}
