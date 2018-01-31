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
        private const int LOWERLIMIT = 0;
        private const int UPPERLIMIT = 100;
        private const int MAX_SCORES = 20;
        private int scoreCount = 0;
        private int scoreTotal = 0;
        private double scoreAverage = 0;

        public CS_HW1_ScoreCalcForm()
        {
            InitializeComponent();
        }

        private void CS_HW1_ScoreCalcForm_Load(object sender, EventArgs e)
        {
            this.ScoreTotalTextBox.Text = scoreTotal.ToString();
            this.ScoreCountTextBox.Text = scoreCount.ToString();
            this.ScoreAverageTextBox.Text = scoreAverage.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (scoreCount < MAX_SCORES)
            {
                var isValidScore = int.TryParse(this.ScoreTextBox.Text, out var newScore);

                if (isValidScore && newScore >= LOWERLIMIT && newScore <= UPPERLIMIT)
                {
                    this.ScoreTextBox.Clear();
                    this.ScoreTextBox.Focus();
                    scoreCount++;
                    scoreTotal += newScore;
                    scoreAverage = Convert.ToDouble(scoreTotal) / scoreCount;
                    this.ScoreCountTextBox.Text = scoreCount.ToString();
                    this.ScoreTotalTextBox.Text = scoreTotal.ToString();
                    this.ScoreAverageTextBox.Text = scoreAverage.ToString();

                    if (scoreCount >= MAX_SCORES)
                    {
                        MessageBox.Show("Maximum number of scores reached [" + MAX_SCORES + "]." +
                                        "\nClick 'Clear Scores' to continue.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearScoresButton.Focus();
                    }
                    else
                    {
                        //doNothing();
                    }
                }

                else if ((isValidScore && newScore < LOWERLIMIT) || (isValidScore && newScore > UPPERLIMIT))
                {
                    MessageBox.Show("Invalid Input!" +
                                    "\n" + "Out of Range [" + LOWERLIMIT + "-" + UPPERLIMIT + "].", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ScoreTextBox.Clear();
                    this.ScoreTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Input!" +
                                    "\nNon-Integer.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ScoreTextBox.Clear();
                    this.ScoreTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Maximum number of scores reached [" + MAX_SCORES + "]." +
                                "\nClick 'Clear Scores' to continue.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearScoresButton.Focus();
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoreCount = 0;
            scoreTotal = 0;
            scoreAverage = 0;
            this.ScoreTextBox.Clear();
            this.ScoreTextBox.Focus();
            this.ScoreCountTextBox.Text = scoreCount.ToString();
            this.ScoreTotalTextBox.Text = scoreTotal.ToString();
            this.ScoreAverageTextBox.Text = scoreAverage.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}