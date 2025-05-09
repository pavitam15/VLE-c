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
    public partial class Calculator : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 0;
            this.CalcTxtBx.Text += input;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 1;
            this.CalcTxtBx.Text += input;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 2;
            this.CalcTxtBx.Text += input;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 3;
            this.CalcTxtBx.Text += input;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 4;
            this.CalcTxtBx.Text += input;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 5;
            this.CalcTxtBx.Text += input;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 6;
            this.CalcTxtBx.Text += input;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 7;
            this.CalcTxtBx.Text += input;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 8;
            this.CalcTxtBx.Text += input;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += 9;
            this.CalcTxtBx.Text += input;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            input += ".";
            this.CalcTxtBx.Text += input;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.CalcTxtBx.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.CalcTxtBx.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation =='+')
            {
                result = num1 + num2;
                CalcTxtBx.Text = result.ToString();
            }
            else if (operation =='-')
            {
                result = num1 - num2;
                CalcTxtBx.Text = result.ToString();
            }
            else if (operation =='*')
            {
                result = num1 * num2;
                CalcTxtBx.Text = result.ToString();
            }
            else if (operation =='/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    CalcTxtBx.Text = result.ToString();
                }
                else
                {
                    CalcTxtBx.Text = "You can't divide by 0!";
                }
            }
        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            MathsHome mathsform = new MathsHome();
            this.Hide();
            mathsform.ShowDialog();
            this.Show();
        }
    }
}
