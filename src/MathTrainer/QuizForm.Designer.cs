namespace MathTrainer
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMultiplication = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubtraction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNumQuestions = new System.Windows.Forms.ToolStripTextBox();
            this.timeAllowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimeAllowed = new System.Windows.Forms.ToolStripTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.Label();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIncorrectAnswers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(254, 165);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Location = new System.Drawing.Point(190, 166);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(57, 20);
            this.txtAnswer.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestType,
            this.numberOfQuestionsToolStripMenuItem,
            this.timeAllowedToolStripMenuItem});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuTestType
            // 
            this.mnuTestType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuTestType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddition,
            this.mnuDivision,
            this.mnuMultiplication,
            this.mnuSubtraction,
            this.mnuSequence});
            this.mnuTestType.Name = "mnuTestType";
            this.mnuTestType.Size = new System.Drawing.Size(188, 22);
            this.mnuTestType.Text = "Test Type";
            // 
            // mnuAddition
            // 
            this.mnuAddition.CheckOnClick = true;
            this.mnuAddition.Name = "mnuAddition";
            this.mnuAddition.Size = new System.Drawing.Size(148, 22);
            this.mnuAddition.Text = "Addition";
            this.mnuAddition.Click += new System.EventHandler(this.mnuAddition_Click);
            // 
            // mnuDivision
            // 
            this.mnuDivision.CheckOnClick = true;
            this.mnuDivision.Name = "mnuDivision";
            this.mnuDivision.Size = new System.Drawing.Size(148, 22);
            this.mnuDivision.Text = "Division";
            this.mnuDivision.Click += new System.EventHandler(this.mnuDivision_Click);
            // 
            // mnuMultiplication
            // 
            this.mnuMultiplication.Checked = true;
            this.mnuMultiplication.CheckOnClick = true;
            this.mnuMultiplication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuMultiplication.Name = "mnuMultiplication";
            this.mnuMultiplication.Size = new System.Drawing.Size(148, 22);
            this.mnuMultiplication.Text = "Multiplication";
            this.mnuMultiplication.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // mnuSubtraction
            // 
            this.mnuSubtraction.CheckOnClick = true;
            this.mnuSubtraction.Name = "mnuSubtraction";
            this.mnuSubtraction.Size = new System.Drawing.Size(148, 22);
            this.mnuSubtraction.Text = "Subtraction";
            this.mnuSubtraction.Click += new System.EventHandler(this.mnuSubtraction_Click);
            // 
            // mnuSequence
            // 
            this.mnuSequence.Name = "mnuSequence";
            this.mnuSequence.Size = new System.Drawing.Size(148, 22);
            this.mnuSequence.Text = "Sequence";
            this.mnuSequence.Click += new System.EventHandler(this.sequenceToolStripMenuItem_Click);
            // 
            // numberOfQuestionsToolStripMenuItem
            // 
            this.numberOfQuestionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.numberOfQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNumQuestions});
            this.numberOfQuestionsToolStripMenuItem.Name = "numberOfQuestionsToolStripMenuItem";
            this.numberOfQuestionsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.numberOfQuestionsToolStripMenuItem.Text = "Number of Questions";
            // 
            // mnuNumQuestions
            // 
            this.mnuNumQuestions.Name = "mnuNumQuestions";
            this.mnuNumQuestions.Size = new System.Drawing.Size(121, 23);
            this.mnuNumQuestions.Text = "20";
            this.mnuNumQuestions.TextChanged += new System.EventHandler(this.mnuNumQuestions_TextChanged);
            // 
            // timeAllowedToolStripMenuItem
            // 
            this.timeAllowedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimeAllowed});
            this.timeAllowedToolStripMenuItem.Name = "timeAllowedToolStripMenuItem";
            this.timeAllowedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.timeAllowedToolStripMenuItem.Text = "Time Allowed";
            this.timeAllowedToolStripMenuItem.Visible = false;
            // 
            // mnuTimeAllowed
            // 
            this.mnuTimeAllowed.Name = "mnuTimeAllowed";
            this.mnuTimeAllowed.Size = new System.Drawing.Size(100, 23);
            this.mnuTimeAllowed.Text = "60";
            this.mnuTimeAllowed.TextChanged += new System.EventHandler(this.mnuTimeAllowed_TextChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 215);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 20);
            this.lblResults.TabIndex = 28;
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCount.Location = new System.Drawing.Point(196, 65);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(26, 23);
            this.lblQuestionCount.TabIndex = 29;
            this.lblQuestionCount.Text = "20";
            this.lblQuestionCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Remaining Questions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Elapsed Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.Location = new System.Drawing.Point(390, 65);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(38, 23);
            this.lblElapsedTime.TabIndex = 36;
            this.lblElapsedTime.Text = "60";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // QuestionText
            // 
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.Location = new System.Drawing.Point(67, 130);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(395, 18);
            this.QuestionText.TabIndex = 38;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.Location = new System.Drawing.Point(171, 29);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(0, 20);
            this.lblTestTitle.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Incorrect Answers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIncorrectAnswers
            // 
            this.lblIncorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAnswers.Location = new System.Drawing.Point(391, 91);
            this.lblIncorrectAnswers.Name = "lblIncorrectAnswers";
            this.lblIncorrectAnswers.Size = new System.Drawing.Size(38, 23);
            this.lblIncorrectAnswers.TabIndex = 42;
            this.lblIncorrectAnswers.Text = "0";
            this.lblIncorrectAnswers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Correct Answers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(197, 91);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(26, 23);
            this.lblCorrectAnswers.TabIndex = 40;
            this.lblCorrectAnswers.Text = "0";
            this.lblCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // QuizForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIncorrectAnswers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuizForm";
            this.Text = "Test Your Skill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuTestType;
        private System.Windows.Forms.ToolStripMenuItem mnuAddition;
        private System.Windows.Forms.ToolStripMenuItem mnuDivision;
        private System.Windows.Forms.ToolStripMenuItem mnuMultiplication;
        private System.Windows.Forms.ToolStripMenuItem mnuSubtraction;
        private System.Windows.Forms.ToolStripMenuItem numberOfQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox mnuNumQuestions;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem timeAllowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox mnuTimeAllowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.ToolStripMenuItem mnuSequence;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIncorrectAnswers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorrectAnswers;
    }
}