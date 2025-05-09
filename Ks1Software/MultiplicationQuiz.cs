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
    public partial class MultiplicationQuiz : Form
    {
        Random randomizer = new Random();

        int multiplicand1;
        int multiplier1;
        int multiplicand2;
        int multiplier2;
        int multiplicand3;
        int multiplier3;
        int multiplicand4;
        int multiplier4;

        int timeLeft2;

        public MultiplicationQuiz()
        {
            InitializeComponent();
        }

        private void BackBtn7_Click(object sender, EventArgs e)
        {
            MathsQuiz quizform = new MathsQuiz();
            this.Hide();
            quizform.ShowDialog();
            this.Show();
        }

        public void StartTheQuiz2()
        {
            multiplicand1 = randomizer.Next(2, 11);
            multiplier1 = randomizer.Next(2, 11);
            multiplicand2 = randomizer.Next(2, 11);
            multiplier2 = randomizer.Next(2, 11);
            multiplicand3 = randomizer.Next(2, 11);
            multiplier3 = randomizer.Next(2, 11);
            multiplicand4 = randomizer.Next(2, 11);
            multiplier4 = randomizer.Next(2, 11);

            timesLeftLbl1.Text = multiplicand1.ToString();
            timesRightLbl1.Text = multiplier1.ToString();
            timesLeftLbl2.Text = multiplicand2.ToString();
            timesRightLbl2.Text = multiplier2.ToString();
            timesLeftLbl3.Text = multiplicand3.ToString();
            timesRightLbl3.Text = multiplier3.ToString();
            timesLeftLbl4.Text = multiplicand4.ToString();
            timesRightLbl4.Text = multiplier4.ToString();

            product1.Value = 0;
            product2.Value = 0;
            product3.Value = 0;
            product4.Value = 0;

            timeLeft2 = 60;
            TimeLbl3.Text = "60 seconds";
            timer3.Start();
        }

        private bool CheckTheAnswer2()
        {
            if ((multiplicand1 * multiplier1 == product1.Value)
                && (multiplicand2 * multiplier2 == product2.Value)
                && (multiplicand3 * multiplier3 == product3.Value)
                && (multiplicand4 * multiplier4 == product4.Value))
                return true;
            else
                return false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer2())
            {
                timer3.Stop();
                MessageBox.Show("You got all of the answers right!", "Well Done!");
                StartBtn3.Enabled = true;
            }
            else if (timeLeft2 > 0)
            {
                timeLeft2 = timeLeft2 - 1;
                TimeLbl3.Text = timeLeft2 + " seconds";
            }
            else
            {
                timer3.Stop();
                TimeLbl3.Text = "Time's up!";
                MessageBox.Show("You didn't quite make it in time!", "Try again?");
                product1.Value = multiplicand1 * multiplier1;
                product2.Value = multiplicand2 * multiplier2;
                product3.Value = multiplicand3 * multiplier3;
                product4.Value = multiplicand4 * multiplier4;
                StartBtn3.Enabled = true;
            }
        }

        private void StartBtn3_Click(object sender, EventArgs e)
        {
            StartTheQuiz2();
            StartBtn3.Enabled = false;
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
