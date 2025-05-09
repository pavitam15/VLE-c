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
    public partial class MathsQuiz : Form
    {
        public MathsQuiz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            MathsHome mathsform = new MathsHome();
            this.Hide();
            mathsform.ShowDialog();
            this.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AdditionQuiz addform = new AdditionQuiz();
            this.Hide();
            addform.ShowDialog();
            this.Show();
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            SubtractionQuiz subform = new SubtractionQuiz();
            this.Hide();
            subform.ShowDialog();
            this.Show();
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            MultiplicationQuiz mulform = new MultiplicationQuiz();
            this.Hide();
            mulform.ShowDialog();
            this.Show();
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            DivisionQuiz divform = new DivisionQuiz();
            this.Hide();
            divform.ShowDialog();
            this.Show();
        }
    }
}
