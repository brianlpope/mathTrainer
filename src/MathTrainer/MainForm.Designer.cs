namespace MathTrainer
{
    partial class MainForm
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
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSequence = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(45, 54);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(247, 31);
            this.btnMultiplication.TabIndex = 0;
            this.btnMultiplication.Text = "Multiplication";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSequence
            // 
            this.btnSequence.Location = new System.Drawing.Point(45, 198);
            this.btnSequence.Name = "btnSequence";
            this.btnSequence.Size = new System.Drawing.Size(247, 31);
            this.btnSequence.TabIndex = 1;
            this.btnSequence.Text = "Sequence";
            this.btnSequence.UseVisualStyleBackColor = true;
            this.btnSequence.Click += new System.EventHandler(this.btnSequence_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(45, 90);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(247, 31);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(45, 126);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(247, 31);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(45, 162);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(247, 31);
            this.btnSubtraction.TabIndex = 4;
            this.btnSubtraction.Text = "Subtraction";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on one of the buttons below to select the type of quiz";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSequence);
            this.Controls.Add(this.btnMultiplication);
            this.Name = "MainForm";
            this.Text = "Math Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSequence;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Label label1;
    }
}