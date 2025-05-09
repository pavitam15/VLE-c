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
    public partial class SubtractionQuiz : Form
    {
        Random randomizer = new Random();

        int minuend1;
        int subtrahend1;
        int minuend2;
        int subtrahend2;
        int minuend3;
        int subtrahend3;
        int minuend4;
        int subtrhend4;

        int timeLeft1;

        public SubtractionQuiz()
        {
            InitializeComponent();
        }

        private void AddLbl_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn6_Click(object sender, EventArgs e)
        {
            MathsQuiz quizform = new MathsQuiz();
            this.Hide();
            quizform.ShowDialog();
            this.Show();
        }

        public void StartTheQuiz1()
        {
            minuend1 = randomizer.Next(1, 31);
            subtrahend1 = randomizer.Next(1, minuend1);
            minuend2 = randomizer.Next(1, 31);
            subtrahend2 = randomizer.Next(1, minuend2);
            minuend3 = randomizer.Next(1, 31);
            subtrahend3 = randomizer.Next(1, minuend3);
            minuend4 = randomizer.Next(1, 31);
            subtrhend4 = randomizer.Next(1, minuend4);

            subLeftLbl1.Text = minuend1.ToString();
            subRightLbl1.Text = subtrahend1.ToString();
            subLeftLbl2.Text = minuend2.ToString();
            subRightLbl2.Text = subtrahend2.ToString();
            subLeftLbl3.Text = minuend3.ToString();
            subRightLbl3.Text = subtrahend3.ToString();
            subLeftLbl4.Text = minuend4.ToString();
            subRightLbl4.Text = subtrhend4.ToString();

            difference1.Value = 0;
            difference2.Value = 0;
            difference3.Value = 0;
            difference4.Value = 0;

            timeLeft1 = 60;
            TimeLbl2.Text = "60 seconds";
            timer2.Start();
        }

        private void StartBtn2_Click(object sender, EventArgs e)
        {
            StartTheQuiz1();
            StartBtn2.Enabled = false;
        }

        private bool CheckTheAnswer1()
        {
            if ((minuend1 - subtrahend1 == difference1.Value)
                && (minuend2 - subtrahend2 == difference2.Value)
                && (minuend3 - subtrahend3 == difference3.Value)
                && (minuend4 - subtrhend4 == difference4.Value))
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer1())
            {
                timer2.Stop();
                MessageBox.Show("You got all of the answers right!", "Well Done!");
                StartBtn2.Enabled = true;
            }
            else if (timeLeft1 > 0)
            {
                timeLeft1 = timeLeft1 - 1;
                TimeLbl2.Text = timeLeft1 + " seconds";
            }
            else
            {
                timer2.Stop();
                TimeLbl2.Text = "Time's up!";
                MessageBox.Show("You didn't quite make it in time!", "Try again?");
                difference1.Value = minuend1 - subtrahend1;
                difference2.Value = minuend2 - subtrahend2;
                difference3.Value = minuend3 - subtrahend3;
                difference4.Value = minuend4 - subtrhend4;
                StartBtn2.Enabled = true;
            }
        }
    }
}
