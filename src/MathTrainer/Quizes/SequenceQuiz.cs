using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTrainer.Quizes
{
    public class SequenceQuiz : Quiz
    {
        public override void LoadQuestions()
        {
            Questions = new List<Question>(QuestionCount);

            for (int i = 0; i < QuestionCount; i++)
            {
                var operand1 = Randomizer.GetValue(GetOptionValue(Constants.MIN_OPERAND_KEY), GetOptionValue(Constants.MAX_OPERAND_KEY));
                var operand2 = Randomizer.GetValue(operand1, GetOptionValue(Constants.MAX_OPERAND_KEY));
                var sequenceLength = GetOptionValue(Constants.SEQUENCE_LENGTH);
                var incrementBy = GetOptionValue(Constants.INCREMENT_BY);
                Questions.Add(new SequenceQuestion(operand1, operand2, sequenceLength, incrementBy));
            }
        }
    }
}
