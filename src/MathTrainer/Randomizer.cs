namespace MathTrainer
{
    using System;

    public static class Randomizer
    {
        private static Random _random = new Random();

        public static int GetValue(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
