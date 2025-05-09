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
    public partial class MathsHome : Form
    {
        public MathsHome()
        {
            InitializeComponent();
        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            HomePage hpform = new HomePage();
            this.Hide();
            hpform.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Calculator calcform = new Calculator();
            this.Hide();
            calcform.ShowDialog();
            this.Show();
        }

        private void QuizBtn_Click(object sender, EventArgs e)
        {
            MathsQuiz quizform = new MathsQuiz();
            this.Hide();
            quizform.ShowDialog();
            this.Show();
        }
    }
}
