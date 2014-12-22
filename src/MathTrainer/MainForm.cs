using System;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            QuizForm frm = new QuizForm('*');
            frm.Show();
        }

        private void LoadSequenceQuiz()
        {
            //SequenceForm frm = new SequenceForm();
            QuizForm frm = new QuizForm('s');
            frm.Show();
        }

        private void btnSequence_Click(object sender, EventArgs e)
        {
            LoadSequenceQuiz();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            QuizForm frm = new QuizForm('+');
            frm.Show();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            QuizForm frm = new QuizForm('/');
            frm.Show();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            QuizForm frm = new QuizForm('-');
            frm.Show();
        }
    }
}
