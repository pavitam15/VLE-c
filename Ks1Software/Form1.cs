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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string firstName = "";

        private void SubmitNameBtn_Click(object sender, EventArgs e)
        {
            firstName = NameTxt.Text;

            HomePage hpform = new HomePage();
            this.Hide();
            hpform.ShowDialog();
            this.Show();
        }

        private void WelcomeLbl1_Click(object sender, EventArgs e)
        {

        }

        private void NameTxt_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                firstName = NameTxt.Text;

                HomePage hpform = new HomePage();
                this.Hide();
                hpform.ShowDialog();
                this.Show();
            }
        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}