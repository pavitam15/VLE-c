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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            HelloLbl1.Text = "Hi " + Form1.firstName + "!";
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void MathsBtn_Click(object sender, EventArgs e)
        {
            MathsHome mathsform = new MathsHome();
            this.Hide();
            mathsform.ShowDialog();
            this.Show();
        }

        private void EnglishBtn_Click(object sender, EventArgs e)
        {
            TextEditor txtform = new TextEditor();
            this.Hide();
            txtform.ShowDialog();
            this.Show();
        }

        private void InternetBtn_Click(object sender, EventArgs e)
        {
            TheInternet internetform = new TheInternet();
            this.Hide();
            internetform.ShowDialog();
            this.Show();
        }
    }
}
