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
            System.Windows.Forms.ToolStrip MainToolStrip;
            this.AddMenuButton = new System.Windows.Forms.ToolStripButton();
            this.SubtractMenuButton = new System.Windows.Forms.ToolStripButton();
            this.MultiplyMenuButton = new System.Windows.Forms.ToolStripButton();
            this.DivideMenuButton = new System.Windows.Forms.ToolStripButton();
            this.SequenceMenuButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionDisplay = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ElapsedTimeDisplay = new System.Windows.Forms.Label();
            this.CorrectCountDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IncorrectCountDisplay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.commonSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionCountInput = new System.Windows.Forms.TextBox();
            this.EquationSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.MinStartOperandInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxStartOperandInput = new System.Windows.Forms.TextBox();
            this.SequenceSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.SequenceLengthInput = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MinStartNumberInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaxStartNumberInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IncrementByInput = new System.Windows.Forms.ComboBox();
            this.QuizTitle = new System.Windows.Forms.Label();
            this.CorrectIndicator = new System.Windows.Forms.PictureBox();
            this.IncorrectIndicator = new System.Windows.Forms.PictureBox();
            this.PastScoresDisplay = new System.Windows.Forms.Label();
            MainToolStrip = new System.Windows.Forms.ToolStrip();
            MainToolStrip.SuspendLayout();
            this.commonSettingsPanel.SuspendLayout();
            this.EquationSettingsPanel.SuspendLayout();
            this.SequenceSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncorrectIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            MainToolStrip.AllowMerge = false;
            MainToolStrip.AutoSize = false;
            MainToolStrip.BackColor = System.Drawing.Color.Black;
            MainToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuButton,
            this.SubtractMenuButton,
            this.MultiplyMenuButton,
            this.DivideMenuButton,
            this.SequenceMenuButton});
            MainToolStrip.Location = new System.Drawing.Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            MainToolStrip.Size = new System.Drawing.Size(638, 40);
            MainToolStrip.TabIndex = 16;
            // 
            // AddMenuButton
            // 
            this.AddMenuButton.AutoSize = false;
            this.AddMenuButton.CheckOnClick = true;
            this.AddMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddMenuButton.ForeColor = System.Drawing.Color.White;
            this.AddMenuButton.Image = global::MathTrainer.Properties.Resources.add;
            this.AddMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddMenuButton.Name = "AddMenuButton";
            this.AddMenuButton.Size = new System.Drawing.Size(48, 36);
            this.AddMenuButton.Click += new System.EventHandler(this.AddMenuButton_ButtonClick);
            // 
            // SubtractMenuButton
            // 
            this.SubtractMenuButton.AutoSize = false;
            this.SubtractMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SubtractMenuButton.Image = global::MathTrainer.Properties.Resources.subtract;
            this.SubtractMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubtractMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SubtractMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubtractMenuButton.Name = "SubtractMenuButton";
            this.SubtractMenuButton.Size = new System.Drawing.Size(48, 36);
            this.SubtractMenuButton.Click += new System.EventHandler(this.SubtractMenuButton_Click);
            // 
            // MultiplyMenuButton
            // 
            this.MultiplyMenuButton.AutoSize = false;
            this.MultiplyMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MultiplyMenuButton.Image = global::MathTrainer.Properties.Resources.multiply;
            this.MultiplyMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MultiplyMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MultiplyMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.MultiplyMenuButton.Name = "MultiplyMenuButton";
            this.MultiplyMenuButton.Size = new System.Drawing.Size(48, 36);
            this.MultiplyMenuButton.Text = "toolStripButton1";
            this.MultiplyMenuButton.Click += new System.EventHandler(this.MultiplyMenuButton_Click);
            // 
            // DivideMenuButton
            // 
            this.DivideMenuButton.AutoSize = false;
            this.DivideMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DivideMenuButton.Image = global::MathTrainer.Properties.Resources.divide;
            this.DivideMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DivideMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DivideMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.DivideMenuButton.Name = "DivideMenuButton";
            this.DivideMenuButton.Size = new System.Drawing.Size(48, 36);
            this.DivideMenuButton.Click += new System.EventHandler(this.DivideMenuButton_Click);
            // 
            // SequenceMenuButton
            // 
            this.SequenceMenuButton.AutoSize = false;
            this.SequenceMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SequenceMenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SequenceMenuButton.Image = global::MathTrainer.Properties.Resources.sequence;
            this.SequenceMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SequenceMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SequenceMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.SequenceMenuButton.Name = "SequenceMenuButton";
            this.SequenceMenuButton.Size = new System.Drawing.Size(63, 36);
            this.SequenceMenuButton.ToolTipText = "Fill in the missing value in a sequence of numbers";
            this.SequenceMenuButton.Click += new System.EventHandler(this.SequenceMenuButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(148, 210);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(56, 24);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // AnswerInput
            // 
            this.AnswerInput.Location = new System.Drawing.Point(68, 213);
            this.AnswerInput.Margin = new System.Windows.Forms.Padding(2);
            this.AnswerInput.Name = "AnswerInput";
            this.AnswerInput.Size = new System.Drawing.Size(42, 20);
            this.AnswerInput.TabIndex = 2;
            this.AnswerInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AnswerInput_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer";
            // 
            // QuestionDisplay
            // 
            this.QuestionDisplay.Location = new System.Drawing.Point(66, 187);
            this.QuestionDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionDisplay.Name = "QuestionDisplay";
            this.QuestionDisplay.Size = new System.Drawing.Size(512, 14);
            this.QuestionDisplay.TabIndex = 4;
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(17, 116);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(56, 24);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(17, 256);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 24);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(17, 116);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 24);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Elapsed Time";
            // 
            // ElapsedTimeDisplay
            // 
            this.ElapsedTimeDisplay.AutoSize = true;
            this.ElapsedTimeDisplay.Location = new System.Drawing.Point(452, 122);
            this.ElapsedTimeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElapsedTimeDisplay.Name = "ElapsedTimeDisplay";
            this.ElapsedTimeDisplay.Size = new System.Drawing.Size(34, 13);
            this.ElapsedTimeDisplay.TabIndex = 10;
            this.ElapsedTimeDisplay.Text = "00:00";
            // 
            // CorrectCountDisplay
            // 
            this.CorrectCountDisplay.AutoSize = true;
            this.CorrectCountDisplay.Location = new System.Drawing.Point(191, 122);
            this.CorrectCountDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CorrectCountDisplay.Name = "CorrectCountDisplay";
            this.CorrectCountDisplay.Size = new System.Drawing.Size(13, 13);
            this.CorrectCountDisplay.TabIndex = 12;
            this.CorrectCountDisplay.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correct";
            // 
            // IncorrectCountDisplay
            // 
            this.IncorrectCountDisplay.AutoSize = true;
            this.IncorrectCountDisplay.Location = new System.Drawing.Point(292, 122);
            this.IncorrectCountDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IncorrectCountDisplay.Name = "IncorrectCountDisplay";
            this.IncorrectCountDisplay.Size = new System.Drawing.Size(13, 13);
            this.IncorrectCountDisplay.TabIndex = 14;
            this.IncorrectCountDisplay.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Incorrect";
            // 
            // commonSettingsPanel
            // 
            this.commonSettingsPanel.BackColor = System.Drawing.Color.Black;
            this.commonSettingsPanel.Controls.Add(this.label3);
            this.commonSettingsPanel.Controls.Add(this.QuestionCountInput);
            this.commonSettingsPanel.Location = new System.Drawing.Point(0, 40);
            this.commonSettingsPanel.Name = "commonSettingsPanel";
            this.commonSettingsPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.commonSettingsPanel.Size = new System.Drawing.Size(100, 30);
            this.commonSettingsPanel.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Questions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionCountInput
            // 
            this.QuestionCountInput.Location = new System.Drawing.Point(63, 5);
            this.QuestionCountInput.MaxLength = 2;
            this.QuestionCountInput.Name = "QuestionCountInput";
            this.QuestionCountInput.Size = new System.Drawing.Size(32, 20);
            this.QuestionCountInput.TabIndex = 0;
            this.QuestionCountInput.Text = "10";
            this.QuestionCountInput.TextChanged += new System.EventHandler(this.QuestionCountInput_TextChanged);
            // 
            // EquationSettingsPanel
            // 
            this.EquationSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EquationSettingsPanel.BackColor = System.Drawing.Color.Black;
            this.EquationSettingsPanel.Controls.Add(this.label11);
            this.EquationSettingsPanel.Controls.Add(this.MinStartOperandInput);
            this.EquationSettingsPanel.Controls.Add(this.label6);
            this.EquationSettingsPanel.Controls.Add(this.MaxStartOperandInput);
            this.EquationSettingsPanel.Location = new System.Drawing.Point(100, 40);
            this.EquationSettingsPanel.Name = "EquationSettingsPanel";
            this.EquationSettingsPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.EquationSettingsPanel.Size = new System.Drawing.Size(538, 30);
            this.EquationSettingsPanel.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.CausesValidation = false;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Min. Operand";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinStartOperandInput
            // 
            this.MinStartOperandInput.Location = new System.Drawing.Point(80, 5);
            this.MinStartOperandInput.MaxLength = 3;
            this.MinStartOperandInput.Name = "MinStartOperandInput";
            this.MinStartOperandInput.Size = new System.Drawing.Size(42, 20);
            this.MinStartOperandInput.TabIndex = 2;
            this.MinStartOperandInput.Text = "1";
            this.MinStartOperandInput.TextChanged += new System.EventHandler(this.MinStartOperandInput_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(128, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max. Operand";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxStartOperandInput
            // 
            this.MaxStartOperandInput.Location = new System.Drawing.Point(208, 5);
            this.MaxStartOperandInput.MaxLength = 3;
            this.MaxStartOperandInput.Name = "MaxStartOperandInput";
            this.MaxStartOperandInput.Size = new System.Drawing.Size(42, 20);
            this.MaxStartOperandInput.TabIndex = 0;
            this.MaxStartOperandInput.Text = "12";
            this.MaxStartOperandInput.TextChanged += new System.EventHandler(this.MaxStartOperandInput_TextChanged);
            // 
            // SequenceSettingsPanel
            // 
            this.SequenceSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SequenceSettingsPanel.BackColor = System.Drawing.Color.Black;
            this.SequenceSettingsPanel.Controls.Add(this.label8);
            this.SequenceSettingsPanel.Controls.Add(this.SequenceLengthInput);
            this.SequenceSettingsPanel.Controls.Add(this.label9);
            this.SequenceSettingsPanel.Controls.Add(this.MinStartNumberInput);
            this.SequenceSettingsPanel.Controls.Add(this.label10);
            this.SequenceSettingsPanel.Controls.Add(this.MaxStartNumberInput);
            this.SequenceSettingsPanel.Controls.Add(this.label12);
            this.SequenceSettingsPanel.Controls.Add(this.IncrementByInput);
            this.SequenceSettingsPanel.Location = new System.Drawing.Point(100, 40);
            this.SequenceSettingsPanel.Name = "SequenceSettingsPanel";
            this.SequenceSettingsPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.SequenceSettingsPanel.Size = new System.Drawing.Size(538, 30);
            this.SequenceSettingsPanel.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sequence Items";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SequenceLengthInput
            // 
            this.SequenceLengthInput.FormattingEnabled = true;
            this.SequenceLengthInput.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SequenceLengthInput.Location = new System.Drawing.Point(93, 5);
            this.SequenceLengthInput.Name = "SequenceLengthInput";
            this.SequenceLengthInput.Size = new System.Drawing.Size(41, 21);
            this.SequenceLengthInput.TabIndex = 4;
            this.SequenceLengthInput.Text = "8";
            this.SequenceLengthInput.SelectedValueChanged += new System.EventHandler(this.SequenceLengthInput_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(140, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Starting Range: Between";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinStartNumberInput
            // 
            this.MinStartNumberInput.Location = new System.Drawing.Point(272, 5);
            this.MinStartNumberInput.MaxLength = 3;
            this.MinStartNumberInput.Name = "MinStartNumberInput";
            this.MinStartNumberInput.Size = new System.Drawing.Size(42, 20);
            this.MinStartNumberInput.TabIndex = 2;
            this.MinStartNumberInput.Text = "1";
            this.MinStartNumberInput.TextChanged += new System.EventHandler(this.MinStartNumberInput_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(320, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "and";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxStartNumberInput
            // 
            this.MaxStartNumberInput.Location = new System.Drawing.Point(351, 5);
            this.MaxStartNumberInput.MaxLength = 3;
            this.MaxStartNumberInput.Name = "MaxStartNumberInput";
            this.MaxStartNumberInput.Size = new System.Drawing.Size(42, 20);
            this.MaxStartNumberInput.TabIndex = 6;
            this.MaxStartNumberInput.Text = "10";
            this.MaxStartNumberInput.TextChanged += new System.EventHandler(this.MaxStartNumberInput_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.CausesValidation = false;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(399, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "IncrementBy";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IncrementByInput
            // 
            this.IncrementByInput.FormattingEnabled = true;
            this.IncrementByInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.IncrementByInput.Location = new System.Drawing.Point(471, 5);
            this.IncrementByInput.Name = "IncrementByInput";
            this.IncrementByInput.Size = new System.Drawing.Size(41, 21);
            this.IncrementByInput.TabIndex = 9;
            this.IncrementByInput.Text = "2";
            this.IncrementByInput.SelectedIndexChanged += new System.EventHandler(this.IncrementByInput_SelectedIndexChanged);
            // 
            // QuizTitle
            // 
            this.QuizTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuizTitle.AutoSize = true;
            this.QuizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizTitle.Location = new System.Drawing.Point(233, 83);
            this.QuizTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuizTitle.Name = "QuizTitle";
            this.QuizTitle.Size = new System.Drawing.Size(123, 24);
            this.QuizTitle.TabIndex = 20;
            this.QuizTitle.Text = "Addition Quiz";
            // 
            // CorrectIndicator
            // 
            this.CorrectIndicator.Image = global::MathTrainer.Properties.Resources.check;
            this.CorrectIndicator.Location = new System.Drawing.Point(115, 210);
            this.CorrectIndicator.Name = "CorrectIndicator";
            this.CorrectIndicator.Size = new System.Drawing.Size(20, 20);
            this.CorrectIndicator.TabIndex = 21;
            this.CorrectIndicator.TabStop = false;
            this.CorrectIndicator.Visible = false;
            // 
            // IncorrectIndicator
            // 
            this.IncorrectIndicator.Image = global::MathTrainer.Properties.Resources.x;
            this.IncorrectIndicator.Location = new System.Drawing.Point(115, 210);
            this.IncorrectIndicator.Name = "IncorrectIndicator";
            this.IncorrectIndicator.Size = new System.Drawing.Size(20, 20);
            this.IncorrectIndicator.TabIndex = 22;
            this.IncorrectIndicator.TabStop = false;
            this.IncorrectIndicator.Visible = false;
            // 
            // PastScoresDisplay
            // 
            this.PastScoresDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PastScoresDisplay.Location = new System.Drawing.Point(163, 262);
            this.PastScoresDisplay.Name = "PastScoresDisplay";
            this.PastScoresDisplay.Size = new System.Drawing.Size(463, 21);
            this.PastScoresDisplay.TabIndex = 23;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 292);
            this.Controls.Add(this.PastScoresDisplay);
            this.Controls.Add(this.CorrectIndicator);
            this.Controls.Add(this.QuizTitle);
            this.Controls.Add(this.commonSettingsPanel);
            this.Controls.Add(MainToolStrip);
            this.Controls.Add(this.IncorrectCountDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CorrectCountDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ElapsedTimeDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.QuestionDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.IncorrectIndicator);
            this.Controls.Add(this.EquationSettingsPanel);
            this.Controls.Add(this.SequenceSettingsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuizForm";
            this.Text = "Math Trainer";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            this.commonSettingsPanel.ResumeLayout(false);
            this.commonSettingsPanel.PerformLayout();
            this.EquationSettingsPanel.ResumeLayout(false);
            this.EquationSettingsPanel.PerformLayout();
            this.SequenceSettingsPanel.ResumeLayout(false);
            this.SequenceSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncorrectIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnswerInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuestionDisplay;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ElapsedTimeDisplay;
        private System.Windows.Forms.Label CorrectCountDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IncorrectCountDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton SubtractMenuButton;
        private System.Windows.Forms.ToolStripButton MultiplyMenuButton;
        private System.Windows.Forms.ToolStripButton DivideMenuButton;
        private System.Windows.Forms.ToolStripButton SequenceMenuButton;
        private System.Windows.Forms.ToolStripButton AddMenuButton;
        private System.Windows.Forms.FlowLayoutPanel commonSettingsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuestionCountInput;
        private System.Windows.Forms.FlowLayoutPanel EquationSettingsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxStartOperandInput;
        private System.Windows.Forms.FlowLayoutPanel SequenceSettingsPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SequenceLengthInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MinStartNumberInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaxStartNumberInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MinStartOperandInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox IncrementByInput;
        private System.Windows.Forms.Label QuizTitle;
        private System.Windows.Forms.PictureBox CorrectIndicator;
        private System.Windows.Forms.PictureBox IncorrectIndicator;
        private System.Windows.Forms.Label PastScoresDisplay;
    }
}