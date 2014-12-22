using System;

namespace MathTrainer
{
    public abstract class Question
    {
        public Question() { }

        public Question(int operand1MinValue, int operand2MinValue, int operand1MaxValue, int operand2MaxValue, Random random)
        {
            Operand1 = new Operand(operand1MinValue, operand1MaxValue);
            Operand2 = new Operand(operand2MinValue, operand2MaxValue);

            Operand1.Value = random.Next(operand1MinValue, operand1MaxValue);
            Operand2.Value = random.Next(operand2MinValue, operand2MaxValue);

            if (Operand2.Value > Operand1.Value)
            {
                int tempOp = Operand1.Value;
                Operand1.Value = Operand2.Value;
                Operand1.Value = tempOp;
            }
        }

        public virtual Operand Operand1 { get; set; }
        public virtual Operand Operand2 { get; set; }

        public abstract string QuestionText { get; }

        public abstract bool CheckAnswer(int answer);
    }
}
