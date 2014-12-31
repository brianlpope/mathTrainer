using MathTrainer.Questions;

namespace MathTrainer.Quizes
{
    using System.Collections.Generic;

    public class SubtractionQuiz : Quiz
    {

        public override void LoadQuestions()
        {
            Questions = new List<Question>(QuestionCount);

            for (int i = 0; i < QuestionCount; i++)
            {
                var operand2 = Randomizer.GetValue(GetOptionValue(Constants.MIN_OPERAND_KEY), GetOptionValue(Constants.MAX_OPERAND_KEY));
                var operand1 = Randomizer.GetValue(GetOptionValue(Constants.MIN_OPERAND_KEY), operand2);
                Questions.Add(new SubtractionQuestion(operand1, operand2));
            }
        }
    }
}
