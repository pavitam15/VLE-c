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
    public partial class DivisionQuiz : Form
    {

        Random randomizer = new Random();

        int divend1;
        int divisor1;
        int divend2;
        int divisor2;
        int divend3;
        int divisor3;
        int divend4;
        int divisor4;

        int timeLeft3;

        public DivisionQuiz()
        {
            InitializeComponent();
        }

        private void BackBtn8_Click(object sender, EventArgs e)
        {
            MathsQuiz quizform = new MathsQuiz();
            this.Hide();
            quizform.ShowDialog();
            this.Show();
        }

        public void StartTheQuiz3()
        {
            divisor1 = randomizer.Next(2, 11);
            int temporaryQuotient1 = randomizer.Next(2, 11);
            divend1 = divisor1 * temporaryQuotient1;
            divisor2 = randomizer.Next(2, 11);
            int temporaryQuotient2 = randomizer.Next(2, 11);
            divend2 = divisor2 * temporaryQuotient2;
            divisor3 = randomizer.Next(2, 11);
            int temporaryQuotient3 = randomizer.Next(2, 11);
            divend3 = divisor3 * temporaryQuotient3;
            divisor4 = randomizer.Next(2, 11);
            int temporaryQuotient4 = randomizer.Next(2, 11);
            divend4 = divisor4 * temporaryQuotient4;

            divLeftLbl1.Text = divend1.ToString();
            divRightLbl1.Text = divisor1.ToString();
            divLeftLbl2.Text = divend2.ToString();
            divRightLbl2.Text = divisor2.ToString();
            divLeftLbl3.Text = divend3.ToString();
            divRightLbl3.Text = divisor3.ToString();
            divLeftLbl4.Text = divend4.ToString();
            divRightLbl4.Text = divisor4.ToString();

            quotient1.Value = 0;
            quotient2.Value = 0;
            quotient3.Value = 0;
            quotient4.Value = 0;

            timeLeft3 = 60;
            TimeLbl4.Text = "60 seconds";
            timer4.Start();
        }

        private bool CheckTheAnswer3()
        {
            if ((divend1 / divisor1 == quotient1.Value)
                && (divend2 / divisor2 == quotient2.Value)
                && (divend3 / divisor3 == quotient3.Value)
                && (divend4 / divisor4 == quotient4.Value))
                return true;
            else
                return false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer3())
            {
                timer4.Stop();
                MessageBox.Show("You got all of the answers right!", "Well Done!");
                StartBtn4.Enabled = true;
            }
            else if (timeLeft3 > 0)
            {
                timeLeft3 = timeLeft3 - 1;
                TimeLbl4.Text = timeLeft3 + " seconds";
            }
            else
            {
                timer4.Stop();
                TimeLbl4.Text = "Time's up!";
                MessageBox.Show("You didn't quite make it in time!", "Try again?");
                quotient1.Value = divend1 / divisor1;
                quotient2.Value = divend2 / divisor2;
                quotient3.Value = divend3 / divisor3;
                quotient4.Value = divend4 / divisor4;
                StartBtn4.Enabled = true;
            }
        }

        private void StartBtn4_Click(object sender, EventArgs e)
        {
            StartTheQuiz3();
            StartBtn4.Enabled = false;
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
