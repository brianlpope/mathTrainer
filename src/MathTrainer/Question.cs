namespace MathTrainer
{
    public abstract class Question
    {
        public abstract string DisplayText { get; }

        public abstract int Answer { get; }
    }
}
