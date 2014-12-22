using System;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class QuizForm : Form
    {
        Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        //private int _maxProblems = 5;
        private Quiz _quiz = new Quiz();
        //private WriteTimeHandler timeMethod;
        //private TimeExpiredHandler timeExpired;
        private Question _currentQuestion = null;
        private char _quizType = '*';
        private int _secondsAllowed = 60;
        

        public QuizForm() 
        {
            InitializeComponent();

            mnuNumQuestions.Text = configuration.AppSettings.Settings["NumberOfQuestions"].Value;
            mnuTimeAllowed.Text = configuration.AppSettings.Settings["AllowedSeconds"].Value;

            switch(configuration.AppSettings.Settings["TestType"].Value)
            {
                case "*":
                    mnuMultiplication.Checked = true;
                    break;
                case "+":
                    mnuAddition.Checked = true;
                    break;
                case "-":
                    mnuSubtraction.Checked = true;
                    break;
                case "/":
                    mnuDivision.Checked = true;
                    break;
                case "s":
                    mnuSequence.Checked = true;
                    break;
            }
            _quizType = configuration.AppSettings.Settings["TestType"].Value[0];

        }

        public QuizForm(char quizType) : this()
        {           
            SetQuizType(quizType);
        }

        private void SetQuizType(char quizType)
        {
            _quizType = quizType;

            ToolStripMenuItem selMenu = null;
            switch(quizType)
            {
                case '*':
                    selMenu = mnuMultiplication;
                    lblTestTitle.Text = "Multiplication";
                    break;
                case '+':
                    selMenu = mnuAddition;
                    lblTestTitle.Text = "Addition";
                    break;
                case '-':
                    selMenu = mnuSubtraction;
                    lblTestTitle.Text = "Subtraction";
                    break;
                case '/':
                    selMenu = mnuDivision;
                    lblTestTitle.Text = "Division";
                    break;
                case 's':
                    selMenu = mnuSequence;
                    lblTestTitle.Text = "Sequence";
                    break;
            }

            selMenu.Checked = true;
            UncheckUnselected(selMenu);
            
            configuration.AppSettings.Settings["TestType"].Value = quizType.ToString();

        }

        private void UpdateTimerLabel(TimeSpan elapsedTime)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(
                    delegate
                    {
                        lblElapsedTime.Text = elapsedTime.Seconds.ToString();
                    }
                ));
            }
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            mnuMultiplication.Click += this.mnuTestTypeItem_CheckedChanged;
            mnuAddition.Click += this.mnuTestTypeItem_CheckedChanged;
            mnuSubtraction.Click += this.mnuTestTypeItem_CheckedChanged;
            mnuDivision.Click += this.mnuTestTypeItem_CheckedChanged;
            mnuSequence.Click += this.mnuTestTypeItem_CheckedChanged;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void StartQuiz()
        {
            btnStart.Enabled = false;
            mnuOptions.Enabled = false;
            lblResults.Text = string.Empty;
            lblCorrectAnswers.Text = string.Empty;
            lblIncorrectAnswers.Text = string.Empty;
            lblQuestionCount.Text = mnuNumQuestions.Text;
            lblElapsedTime.BackColor = Color.White;
            _quiz.SecondsAllowed = int.Parse(mnuTimeAllowed.Text);
            _quiz.TimeWriter = UpdateTimerLabel;
            _quiz.QuestionCount = int.Parse(mnuNumQuestions.Text);
            
            AcceptButton = btnNext;

            GetQuestion();

            btnNext.Enabled = true;
            txtAnswer.Enabled = true;
            txtAnswer.Focus();

            _quiz.Start();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ProcessAnswer();
        }

        private void GetQuestion()
        {
            _currentQuestion = _quiz.GetQuestion(_quizType);
            QuestionText.Text = _currentQuestion.QuestionText;
        }

        private void ProcessAnswer()
        {
            int answer;
            bool isValidAnswer = int.TryParse(txtAnswer.Text, out answer);

            _quiz.QuestionCount--;
            lblQuestionCount.Text = _quiz.QuestionCount.ToString();

            if (_currentQuestion.CheckAnswer(answer))
            {
                ProcessCorrectAnswer(); 
            }
            else
            {
                ProcessIncorrectAnswer();
            }

            if (_quiz.QuestionCount > 0)
            {
                GetQuestion();
            }
            else
            {
                lblResults.Text = string.Format("Contratulations!  You're done.  {0} out of {1}", _quiz.RightCount, mnuNumQuestions.Text);
                StopQuiz();
            }

            txtAnswer.Focus();
        }

        private async Task HighlightAnswer(Label answerLabel, Color backgroundColor)
        {
            answerLabel.BackColor = backgroundColor;
            answerLabel.Refresh();
            await Task.Delay(1000);

            answerLabel.BackColor = Color.White;
            answerLabel.Refresh();
        }

        private async void ProcessIncorrectAnswer()
        {
            lblQuestionCount.Text = _quiz.QuestionCount.ToString();
            _quiz.WrongCount++;
            lblIncorrectAnswers.Text = _quiz.WrongCount.ToString();
            txtAnswer.Text = string.Empty;
            await HighlightAnswer(lblIncorrectAnswers, Color.Pink);
        }

        private async void ProcessCorrectAnswer()
        {
            txtAnswer.Text = string.Empty;
            _quiz.RightCount++;
            lblCorrectAnswers.Text = _quiz.RightCount.ToString();
            await HighlightAnswer(lblCorrectAnswers, Color.Green);
        }

        private void StopQuiz()
        {
            _quiz.Stop();
            btnNext.Enabled = false;
            txtAnswer.Enabled = false;
            mnuOptions.Enabled = true;
            QuestionText.Text = string.Empty;
            btnStart.Enabled = true;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetQuizType('*');
        }

        private void mnuAddition_Click(object sender, EventArgs e)
        {
            SetQuizType('+');
        }

        private void mnuDivision_Click(object sender, EventArgs e)
        {
            SetQuizType('/');
        }

        private void mnuSubtraction_Click(object sender, EventArgs e)
        {
            SetQuizType('-');
        }

        private void UncheckUnselected(ToolStripMenuItem selectedItem)
        {
            var enumerator = mnuTestType.DropDownItems.GetEnumerator();

            while(enumerator.MoveNext())
            {
                ToolStripMenuItem item = (ToolStripMenuItem)enumerator.Current;
                item.Checked = item == selectedItem;
            }
        }

        private void mnuTestTypeItem_CheckedChanged(object sender, EventArgs e)
        {
            UncheckUnselected(((ToolStripMenuItem)sender));
        }

        private void mnuNumQuestions_TextChanged(object sender, EventArgs e)
        {
            lblQuestionCount.Text = mnuNumQuestions.Text;
            configuration.AppSettings.Settings["NumberOfQuestions"].Value = mnuNumQuestions.Text;
        }

        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void mnuTimeAllowed_TextChanged(object sender, EventArgs e)
        {
            _secondsAllowed = int.Parse(mnuTimeAllowed.Text);
            lblElapsedTime.Text = "0";// mnuTimeAllowed.Text;
            configuration.AppSettings.Settings["AllowedSeconds"].Value = mnuTimeAllowed.Text;
        }

        private void sequenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetQuizType('s');
        }

        private void numberOfQuestionsToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            configuration.AppSettings.Settings["NumberOfQuestions"].Value = mnuNumQuestions.Text;
        }
    }
}
