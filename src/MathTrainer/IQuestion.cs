namespace MathTrainer
{
    public interface IQuestion
    {
        string DisplayText { get; set; }

        int Answer { get; set; }
    }
}
