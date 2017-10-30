using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{


    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            input += "C";

            this.textBox1.Text = "";

            this.input = string.Empty;

            this.operand1 = string.Empty;

            this.operand2 = string.Empty;


        }



        private void btndivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }

        private void btnstar_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;


        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;

        }




        private void btnequals_Click(object sender, EventArgs e)
        {
            operand2 = input;

            double num1, num2;

            double.TryParse(operand1, out num1);

            double.TryParse(operand2, out num2);

            if (operation == '+')

            {

                result = num1 + num2; //Nəticəni göstərmək


                textBox1.Text = result.ToString();

            }
            else if (operation == '-')

            {

                result = num1 - num2;

                textBox1.Text = result.ToString();

            }

            else if (operation == '*')

            {

                result = num1 * num2;

                textBox1.Text = result.ToString();

            }

            else if (operation == '/')

            {
                if (num2 != 0)

                {

                    result = num1 / num2;

                    textBox1.Text = result.ToString();

                }

                else

                {

                    textBox1.Text = "DIV/Zero!";

                }
            }


        }
    }
}
