namespace MathTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Quizes;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Threading;

    public partial class QuizForm : Form
    {
        private Quiz _quiz;
        private Quiz.ElapsedTimeDelegate _elapsedTimeDelegate;

        public QuizForm()
        {
            InitializeComponent();
            _quiz = new AdditionQuiz();
            _elapsedTimeDelegate = ShowElapsedTime;
        }

        private void LoadQuizWithOptions()
        {
            var options = new Dictionary<string, int>();
            if (EquationSettingsPanel.Visible)
            {
                options.Add(Constants.MIN_OPERAND_KEY, ParseSetting(Properties.Settings.Default.MinOperand, 1));
                options.Add(Constants.MAX_OPERAND_KEY, ParseSetting(Properties.Settings.Default.MaxOperand, 12));
            }
            else if (SequenceSettingsPanel.Visible)
            {
                options.Add(Constants.MIN_OPERAND_KEY, ParseSetting(Properties.Settings.Default.MinSequence, 1));
                options.Add(Constants.MAX_OPERAND_KEY, ParseSetting(Properties.Settings.Default.MaxSequence, 10));
                options.Add(Constants.SEQUENCE_LENGTH, ParseSetting(Properties.Settings.Default.SequenceLength, 4));
                options.Add(Constants.INCREMENT_BY, ParseSetting(Properties.Settings.Default.IncrementBy, 2));
            }

            _quiz.Options = options;
            _quiz.QuestionCount = ParseSetting(QuestionCountInput.Text, 10);
            _quiz.LoadQuestions();
        }

        private void ShowElapsedTime(TimeSpan elapsedTime) 
        {
            if (ElapsedTimeDisplay.InvokeRequired)
            {
                // Marshal this call back to the UI thread (via the form instance)... 
                ElapsedTimeDisplay.BeginInvoke(_elapsedTimeDelegate, new object[] { elapsedTime });
            }
            else
            {
                ElapsedTimeDisplay.Text = string.Format("{0:00}:{1:00}", elapsedTime.Minutes, elapsedTime.Seconds);
            } 
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            if (!_quiz.IsPaused)
            {
                InitializeValues();
                LoadQuizWithOptions();
                QuestionDisplay.Text = _quiz.GetFirstQuestion().DisplayText;
            }

            AnswerInput.Focus();
            _quiz.Start(_elapsedTimeDelegate);
            PauseButton.BringToFront();
            _quiz.IsPaused = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _quiz.Stop();
            Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProcessNextQuestion();
        }

        private int ParseAnswer(string answerText)
        {
            int answer = -1;
            int.TryParse(answerText, out answer);

            return answer;
        }

        private void ProcessNextQuestion()
        {
            int answer = ParseAnswer(AnswerInput.Text);

            ShowVisualCue(_quiz.CheckAnswer(answer));

            _quiz.UpdateCorrectIncorrectCount(answer);
            CorrectCountDisplay.Text = _quiz.CorrectCount.ToString();
            IncorrectCountDisplay.Text = _quiz.IncorrectCount.ToString();

            AnswerInput.Text = string.Empty;
            AnswerInput.Focus();


            if (_quiz.HasMoreQuestions())
            {
                QuestionDisplay.Text = _quiz.NextQuestion.DisplayText;
            }
            else
            {
                QuestionDisplay.Text = "Done";
                _quiz.IsPaused = false;
                _quiz.Stop();
                StartButton.BringToFront();
                NextButton.Enabled = false;

                var scores = Properties.Settings.Default.Scores ?? new System.Collections.Specialized.StringCollection();
                scores.Add(((double)_quiz.CorrectCount / (double)_quiz.QuestionCount).ToString("P0"));
                Properties.Settings.Default.Scores = scores;
                Properties.Settings.Default.Save();

                DisplayPastScores();
            }
        }

        private void InitializeValues()
        {
            AnswerInput.Text = string.Empty;
            CorrectCountDisplay.Text = "0";
            IncorrectCountDisplay.Text = "0";
            ElapsedTimeDisplay.Text = "00:00";
            QuestionDisplay.Text = string.Empty;
            NextButton.Enabled = true;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _quiz.IsPaused = true;
            StartButton.BringToFront();
            NextButton.Enabled = false;
            _quiz.Stop();
        }

        private void AddMenuButton_ButtonClick(object sender, EventArgs e)
        {
            _quiz = new AdditionQuiz();
            QuizTitle.Text = "Addition Quiz";
            EnableEquationSettingsPanel();
        }

        private void SequenceMenuButton_Click(object sender, EventArgs e)
        {
            QuizTitle.Text = "Sequence Quiz";
            _quiz = new SequenceQuiz();
            EnableSequenceQuiz();
        }

        private void EnableSequenceQuiz()
        {
            SequenceSettingsPanel.Visible = true;
            EquationSettingsPanel.Visible = false;
        }

        private void EnableEquationSettingsPanel()

        {
            SequenceSettingsPanel.Visible = false;
            EquationSettingsPanel.Visible = true;
        }

        private int ParseSetting(string setting, int defaultValue)
        {
            int value;
            if(!int.TryParse(setting, out value))
            {
                value = defaultValue;
            }
            return value;
        }

        private void SubtractMenuButton_Click(object sender, EventArgs e)
        {
            _quiz = new SubtractionQuiz();
            QuizTitle.Text = "Subtraction Quiz";
            EnableEquationSettingsPanel();
        }

        private void MultiplyMenuButton_Click(object sender, EventArgs e)
        {
            QuizTitle.Text = "Multiplication Quiz";
            _quiz = new MultiplicationQuiz();
            EnableEquationSettingsPanel();
        }

        private void DivideMenuButton_Click(object sender, EventArgs e)
        {
            QuizTitle.Text = "Division Quiz";
            _quiz = new DivisionQuiz();
            EnableEquationSettingsPanel();
        }

        private void AnswerInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProcessNextQuestion();
            }
        }

        private async void ShowVisualCue(bool isCorrect)
        {
            if (isCorrect)
            {
                CorrectIndicator.Visible = true;
            }
            else
            {
                IncorrectIndicator.Visible = true;
            }

            await Task.Delay(1000);

            CorrectIndicator.Visible = false;
            IncorrectIndicator.Visible = false;
        }

        private void QuestionCountInput_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.QuestionCount = QuestionCountInput.Text;
        }

        private void MinStartOperandInput_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinOperand = MinStartOperandInput.Text;
        }

        private void MaxStartOperandInput_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxOperand = MaxStartOperandInput.Text;
        }

        private void SequenceLengthInput_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SequenceLength = SequenceLengthInput.Text;
        }

        private void MinStartNumberInput_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinSequence = MinStartNumberInput.Text;
        }

        private void MaxStartNumberInput_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxSequence = MaxStartNumberInput.Text;
        }

        private void IncrementByInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IncrementBy = IncrementByInput.Text;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            QuestionCountInput.Text = Properties.Settings.Default.QuestionCount;
            MinStartOperandInput.Text = Properties.Settings.Default.MinOperand;
            MaxStartOperandInput.Text = Properties.Settings.Default.MaxOperand;
            MinStartNumberInput.Text = Properties.Settings.Default.MinSequence;
            MaxStartNumberInput.Text = Properties.Settings.Default.MaxSequence;
            SequenceLengthInput.Text = Properties.Settings.Default.SequenceLength;
            IncrementByInput.Text = Properties.Settings.Default.IncrementBy;

            DisplayPastScores();
        }

        private void DisplayPastScores()
        {
            string[] value = new string[Properties.Settings.Default.Scores.Count];
            Properties.Settings.Default.Scores.CopyTo(value, 0);

            PastScoresDisplay.Text = string.Join(", ", value);
        }
    }
}
