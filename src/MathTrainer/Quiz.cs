using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace MathTrainer
{
    public delegate void WriteTimeHandler(TimeSpan elapsedTime);
    public delegate void TimeExpiredHandler();

    public class Quiz
    {
        Timer timer = new Timer(1000);
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public int QuestionCount { get; set; }
        public int RightCount { get; set; }
        public int WrongCount { get; set; }
        public int SecondsAllowed { get; set; }
        public WriteTimeHandler TimeWriter { get; set; }
        public TimeExpiredHandler TimeExpired { get; set; }

        private Random _random = new Random();

        public Quiz() 
        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            ElapsedTime = DateTime.Now.Subtract(StartTime);
            TimeWriter(ElapsedTime);
        }

        public void Start()
        {
            timer.Enabled = true;
            timer.Start();
            RightCount = 0;
            WrongCount = 0;
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            timer.Stop();
            timer.Enabled = false;
        }

        public Question GetQuestion(char selOperator)
        {
            return QuestionFactory.GetQuestion(selOperator, _random);
        }
    }

    public class QuestionFactory
    {
        public static Question GetQuestion(char selOperator, Random random)
        {
            Question question = null;

            switch(selOperator)
            {
                case '*':
                    question = new MultiplicationQuestion(random);
                    break;
                case '+':
                    question = new AdditionQuestion(random);
                    break;
                case '-':
                    question = new SubtractionQuestion(random);
                    break;
                case '/':
                    question = new DivisionQuestion(random);

                    while (question.Operand1.Value % question.Operand2.Value != 0)
                    {
                        question.Operand2.Value++;
                    }
                    break;
                case 's':
                    question = new Sequence(random);
                    break;
            }

            return question;
        }
    }
}
