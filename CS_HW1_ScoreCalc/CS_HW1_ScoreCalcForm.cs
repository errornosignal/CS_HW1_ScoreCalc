using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_HW1_ScoreCalc
{
    public partial class CS_HW1_ScoreCalcForm : Form
    {
        private int scoreCount = 0;
        private double scoreTotal = 0;

        public CS_HW1_ScoreCalcForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var isValidScore = double.TryParse(this.ScoreTextBox.Text, out var newScore);

            if (isValidScore && newScore >= 0 && newScore <= 100)
            {
                this.ScoreTextBox.Clear();
                this.ScoreTextBox.Focus();
                scoreCount++;
                scoreTotal += newScore;
                var scoreAverage = scoreTotal / scoreCount;
                this.ScoreCountTextBox.Text = scoreCount.ToString();
                this.ScoreTotalTextBox.Text = scoreTotal.ToString();
                this.ScoreAverageTextBox.Text = scoreAverage.ToString();
            }

            else if ((isValidScore && newScore < 0) || (isValidScore && newScore > 100))
            {
                this.ScoreTextBox.Clear();
                this.ScoreTextBox.Focus();
                MessageBox.Show("Invalid Input!\nOut of Range [0-100]", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ScoreTextBox.Clear();
                this.ScoreTextBox.Focus();
                MessageBox.Show("Invalid Input!\nNon-Numeric", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            this.ScoreTextBox.Clear();
            this.ScoreTotalTextBox.Clear();
            this.ScoreCountTextBox.Clear();
            this.ScoreAverageTextBox.Clear();
            this.ScoreTextBox.Focus();
            scoreCount = 0;
            scoreTotal = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
