namespace MathTrainer
{
    using System;
    using System.Collections.Generic;
    using Timer = System.Timers.Timer;

    public abstract class Quiz
    {
        private Timer _timer;
        private ElapsedTimeDelegate _elapsedTimeDelegate;
        private double _runningSeconds;
        private int _currentQuestionIndex = 0;
        private bool _isPaused = false;

        public delegate void ElapsedTimeDelegate(TimeSpan elapsedTime);

        public Quiz()
        {
            _timer = new Timer(1000);
            _timer.Enabled = false;
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _runningSeconds++;
            ElapsedTime = TimeSpan.FromSeconds(_runningSeconds);
            _elapsedTimeDelegate(ElapsedTime);
        }

        public virtual TimeSpan ElapsedTime { get; private set; }

        public Question GetFirstQuestion()
        {
            return Questions[0];
        }

        public bool HasMoreQuestions()
        {
            int nextIndex = _currentQuestionIndex + 1;
            return Questions != null && nextIndex < Questions.Count;
        }

        private void IncrementQuestionIndex()
        {

        }


        public Question NextQuestion
        {
            get
            {           
                Question returnVal = null;
                if (HasMoreQuestions())
                {
                    returnVal =  Questions[++_currentQuestionIndex];
                }
                return returnVal;
            }
        }

        public virtual int CorrectCount { get; set; }

        public virtual int IncorrectCount { get; set; }

        public virtual int QuestionCount { get; set; }

        public virtual decimal PercentCorrect { get; set; }

        public virtual IDictionary<string, int> Options { get; set; }

        public virtual bool CheckAnswer(int answer)
        {
            bool isCorrect = answer == CurrentQuestion.Answer;
            return isCorrect;
        }

        public bool IsPaused {
            get { return _isPaused; }
            set { _isPaused = value; } 
        }

        public virtual void UpdateCorrectIncorrectCount(int answer)
        {
            bool isCorrect = CheckAnswer(answer);
            if (isCorrect)
            {
                CorrectCount++;
                return;
            }

            IncorrectCount++;
        }

        public Question CurrentQuestion
        {
            get { return Questions[_currentQuestionIndex]; }
        }

        public virtual List<Question> Questions { get; set; }

        public abstract void LoadQuestions();

        public virtual void Start(ElapsedTimeDelegate elapsedTimeDelegate)
        {
            if(!IsPaused)
            { 
                _elapsedTimeDelegate = elapsedTimeDelegate;
                InitializeQuiz();
            }
            _timer.Enabled = true;
        }

        private void InitializeQuiz()
        {
            _runningSeconds = 0;
            _currentQuestionIndex = 0;
            CorrectCount = 0;
            IncorrectCount = 0;
        }

        public virtual void Stop()
        {
            _timer.Enabled = false;
        }

        protected virtual int GetOptionValue(string optionName)
        {
            int value = 1;

            if (Options.ContainsKey(optionName))
            {
                value = Options[optionName];
            }

            return value;
        }
    }
}
