namespace CS_HW1_ScoreCalc
{
    partial class CS_HW1_ScoreCalcForm
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreTotalLabel = new System.Windows.Forms.Label();
            this.ScoreCountLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.ScoreCountTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.ScoreAverageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(39, 12);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreTotalLabel
            // 
            this.ScoreTotalLabel.AutoSize = true;
            this.ScoreTotalLabel.Location = new System.Drawing.Point(12, 36);
            this.ScoreTotalLabel.Name = "ScoreTotalLabel";
            this.ScoreTotalLabel.Size = new System.Drawing.Size(65, 13);
            this.ScoreTotalLabel.TabIndex = 1;
            this.ScoreTotalLabel.Text = "Score Total:";
            // 
            // ScoreCountLabel
            // 
            this.ScoreCountLabel.AutoSize = true;
            this.ScoreCountLabel.Location = new System.Drawing.Point(8, 64);
            this.ScoreCountLabel.Name = "ScoreCountLabel";
            this.ScoreCountLabel.Size = new System.Drawing.Size(69, 13);
            this.ScoreCountLabel.TabIndex = 2;
            this.ScoreCountLabel.Text = "Score Count:";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(95, 9);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(39, 20);
            this.ScoreTextBox.TabIndex = 1;
            // 
            // ScoreTotalTextBox
            // 
            this.ScoreTotalTextBox.Enabled = false;
            this.ScoreTotalTextBox.Location = new System.Drawing.Point(95, 33);
            this.ScoreTotalTextBox.Name = "ScoreTotalTextBox";
            this.ScoreTotalTextBox.ReadOnly = true;
            this.ScoreTotalTextBox.Size = new System.Drawing.Size(39, 20);
            this.ScoreTotalTextBox.TabIndex = 0;
            this.ScoreTotalTextBox.TabStop = false;
            // 
            // ScoreCountTextBox
            // 
            this.ScoreCountTextBox.Enabled = false;
            this.ScoreCountTextBox.Location = new System.Drawing.Point(95, 61);
            this.ScoreCountTextBox.Name = "ScoreCountTextBox";
            this.ScoreCountTextBox.ReadOnly = true;
            this.ScoreCountTextBox.Size = new System.Drawing.Size(39, 20);
            this.ScoreCountTextBox.TabIndex = 0;
            this.ScoreCountTextBox.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(147, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(42, 113);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(92, 23);
            this.btnClearScores.TabIndex = 3;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(147, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(27, 88);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(50, 13);
            this.AverageLabel.TabIndex = 9;
            this.AverageLabel.Text = "Average:";
            // 
            // ScoreAverageTextBox
            // 
            this.ScoreAverageTextBox.Enabled = false;
            this.ScoreAverageTextBox.Location = new System.Drawing.Point(95, 85);
            this.ScoreAverageTextBox.Name = "ScoreAverageTextBox";
            this.ScoreAverageTextBox.ReadOnly = true;
            this.ScoreAverageTextBox.Size = new System.Drawing.Size(39, 20);
            this.ScoreAverageTextBox.TabIndex = 0;
            this.ScoreAverageTextBox.TabStop = false;
            // 
            // CS_HW1_ScoreCalcForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(214, 146);
            this.Controls.Add(this.ScoreAverageTextBox);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ScoreCountTextBox);
            this.Controls.Add(this.ScoreTotalTextBox);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.ScoreCountLabel);
            this.Controls.Add(this.ScoreTotalLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "CS_HW1_ScoreCalcForm";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreTotalLabel;
        private System.Windows.Forms.Label ScoreCountLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.TextBox ScoreTotalTextBox;
        private System.Windows.Forms.TextBox ScoreCountTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.TextBox ScoreAverageTextBox;
    }
}

