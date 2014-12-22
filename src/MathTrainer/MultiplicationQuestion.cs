﻿using System;

namespace MathTrainer
{
    public class MultiplicationQuestion : Question
    {
        public MultiplicationQuestion(Random random) : base(1,1,12,12, random)
        {
        }

        public MultiplicationQuestion(int operand1MinValue, int operand2MinValue, int operand1MaxValue, int operand2MaxValue, Random random)
            : base(operand1MinValue, operand2MinValue, operand1MaxValue, operand2MaxValue, random)
        {

        }

        public override bool CheckAnswer(int attempt)
        {
            int answer = Operand1.Value * Operand2.Value;
            return attempt == answer;
        }

        public override string QuestionText
        {
            get
            {
                return Operand1.Value + " * " + Operand2.Value;
            }
        }
    }
}
