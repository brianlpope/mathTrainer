using MathTrainer.Questions;

namespace MathTrainer.Quizes
{
    using System.Collections.Generic;

    public class DivisionQuiz : Quiz
    {

        public override void LoadQuestions()
        {
            Questions = new List<Question>(QuestionCount);

            for (int i = 0; i < QuestionCount; i++)
            {
                var operand1 = Randomizer.GetValue(GetOptionValue(Constants.MIN_OPERAND_KEY), GetOptionValue(Constants.MAX_OPERAND_KEY));
                var operand2 = operand1 * Randomizer.GetValue(GetOptionValue(Constants.MIN_OPERAND_KEY), GetOptionValue(Constants.MAX_OPERAND_KEY));
                Questions.Add(new DivisionQuestion(operand1, operand2));
            }
        }
    }
}
