using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ks1Software
{
    public partial class AdditionQuiz : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;
        int addend3;
        int addend4;
        int addend5;
        int addend6;
        int addend7;
        int addend8;

        int timeLeft;

        public AdditionQuiz()
        {
            InitializeComponent();
        }

        private void BackBtn5_Click(object sender, EventArgs e)
        {
            MathsQuiz quizform = new MathsQuiz();
            this.Hide();
            quizform.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(21);
            addend2 = randomizer.Next(21);
            addend3 = randomizer.Next(21);
            addend4 = randomizer.Next(21);
            addend5 = randomizer.Next(21);
            addend6 = randomizer.Next(21);
            addend7 = randomizer.Next(21);
            addend8 = randomizer.Next(21);

            plusLeftLbl1.Text = addend1.ToString();
            plusRightLbl1.Text = addend2.ToString();
            plusLeftLbl2.Text = addend3.ToString();
            plusRightLbl2.Text = addend4.ToString();
            plusLeftLbl3.Text = addend5.ToString();
            plusRightLbl3.Text = addend6.ToString();
            plusLeftLbl4.Text = addend7.ToString();
            plusRightLbl4.Text = addend8.ToString();

            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;
            sum4.Value = 0;

            timeLeft = 60;
            TimeLbl1.Text = "60 seconds";
            timer1.Start();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartBtn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all of the answers right!", "Well Done!");
                StartBtn.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimeLbl1.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                TimeLbl1.Text = "Time's up!";
                MessageBox.Show("You didn't quite make it in time!", "Try again?");
                sum1.Value = addend1 + addend2;
                sum2.Value = addend3 + addend4;
                sum3.Value = addend5 + addend6;
                sum4.Value = addend7 + addend8;
                StartBtn.Enabled = true;
            }
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum1.Value)
                && (addend3 + addend4 == sum2.Value)
                && (addend5 + addend6 == sum3.Value)
                && (addend7 + addend8 == sum4.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
