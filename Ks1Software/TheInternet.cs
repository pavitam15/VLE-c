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
    public partial class TheInternet : Form
    {
        public TheInternet()
        {
            InitializeComponent();
        }

        private void URLTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser.Navigate(URLTxtBx.Text);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URLTxtBx.Text))
            webBrowser.Navigate(URLTxtBx.Text);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hpform = new HomePage();
            this.Hide();
            hpform.ShowDialog();
            this.Show();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type your URL into the search box then hit search!", "Help");
        }
    }
}
