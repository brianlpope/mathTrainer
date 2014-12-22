namespace MathTrainer
{
    public class Operand
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public int Value { get; set; }

        public Operand() { }
        
        public Operand(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}
