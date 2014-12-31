namespace MathTrainer.Questions
{
    public class SubtractionQuestion : Question
    {
        public SubtractionQuestion()
        {
        }
        
        public SubtractionQuestion(int operand1, int operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public int Operand1 { get; set; }

        public int Operand2 { get; set; }

        public override string DisplayText
        {
            get { return string.Concat(Operand2, " - ", Operand1); }

        }

        public override int Answer
        {
            get { return Operand2 - Operand1; }
        }
    }
}
