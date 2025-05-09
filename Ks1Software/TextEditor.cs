using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ks1Software
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.Text = " ";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WritingTxtBx.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            saveFileDialog1.ShowDialog();
            WritingTxtBx.SaveFile(saveFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingTxtBx.SelectAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a notepad to help you practice your writing!");
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            WritingTxtBx.SelectionFont = fontDialog1.Font;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            WritingTxtBx.SelectionColor = colorDialog1.Color;
        }

        private void BackBtn3_Click(object sender, EventArgs e)
        {
            HomePage hpform = new HomePage();
            this.Hide();
            hpform.ShowDialog();
            this.Show();
        }
    }
}
