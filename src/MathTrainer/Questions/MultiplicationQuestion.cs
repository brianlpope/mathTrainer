namespace MathTrainer.Questions
{
    public class MultiplicationQuestion : Question
    {
        public MultiplicationQuestion()
        {
        }
        
        public MultiplicationQuestion(int operand1, int operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public int Operand1 { get; set; }

        public int Operand2 { get; set; }

        public override string DisplayText
        {
            get { return string.Concat(Operand1, " * ", Operand2); }

        }

        public override int Answer
        {
            get { return Operand1 * Operand2; }
        }
    }
}
