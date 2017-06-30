using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator2 : Form
    {
        public Calculator2()
        {
            InitializeComponent();
        }
        //Declaring variables
        char currentSign = ' ';
        double result = 0;
        string txtBoxContent, labelContent;

        //Checks if any button from 0-9 is pressed
        private void button1_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "1";
            this.label1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "2";
            this.label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "3";
            this.label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "4";
            this.label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "5";
            this.label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "6";
            this.label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "7";
            this.label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "8";
            this.label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "9";
            this.label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {

            this.textBox1.Text += "0";
            this.label1.Text += "0";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.Calculations();
            this.label1.Text += "+";
            this.currentSign = '+';
            this.textBox1.Text = "";
        }
        //On operation click
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            if (textBox1.Text != " " && textBox1.Text != "-")
            {
                this.Calculations();
            }

            this.label1.Text += "-";
            this.currentSign = '-';
            this.textBox1.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.Calculations();
            this.label1.Text += "*";
            this.currentSign = '*';
            this.textBox1.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.Calculations();
            this.label1.Text += "/";
            this.currentSign = '/';
            this.textBox1.Text = "";
        }
        //Button Clear
        private void button11_Click(object sender, EventArgs e)
        {
            this.currentSign = ' ';
            this.textBox1.Text = "";
            this.label1.Text = "";
            this.result = 0;
        }
        //Calculations
        private void Calculations()
        {
            switch (currentSign)
            {
                case '+':
                    this.result = this.result + double.Parse(this.textBox1.Text);
                    break;
                case '-':
                    this.result = this.result - double.Parse(this.textBox1.Text);
                    break;
                case '*':
                    this.result = this.result * double.Parse(this.textBox1.Text);
                    break;
                case '/':
                    if (textBox1.Text == "0")
                    {
                        MessageBox.Show("Can't devide by 0!");
                    }
                    this.result = this.result / double.Parse(this.textBox1.Text);
                    break;
                case '√':

                    try
                    {
                        this.result = Math.Sqrt(double.Parse(this.textBox1.Text));
                    }
                    catch (System.FormatException)
                    {
                        
                        this.label1.Text = "√";

                    }
                    break;
                case '^':
                    this.result = Math.Pow(this.result, double.Parse(this.textBox1.Text));
                    break;
                case ' ':
                    try
                    {
                        this.result = double.Parse(this.textBox1.Text);
                    }
                    catch (System.FormatException)
                    {
                        break;
                    }

                    break;
               default:
                    break;
            }
        }
        // Button Equals
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            this.Calculations();
            this.textBox1.Text = this.result.ToString();
            this.currentSign = ' ';
            this.label1.Text = "";
        }
        //form Color and heading
        private void Calculator2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.Text = "Calculator";
            this.textBox1.BackColor = Color.Black;
            this.button0.ForeColor = Color.WhiteSmoke;
            this.button1.ForeColor = Color.WhiteSmoke;
            this.button2.ForeColor = Color.WhiteSmoke;
            this.button3.ForeColor = Color.WhiteSmoke;
            this.button4.ForeColor = Color.WhiteSmoke;
            this.button5.ForeColor = Color.WhiteSmoke;
            this.button6.ForeColor = Color.WhiteSmoke;
            this.button7.ForeColor = Color.WhiteSmoke;
            this.button8.ForeColor = Color.WhiteSmoke;
            this.button9.ForeColor = Color.WhiteSmoke;
            this.buttonSqrt.ForeColor = Color.WhiteSmoke;
            this.buttonPow.ForeColor = Color.WhiteSmoke;
            this.buttonPoint.ForeColor = Color.WhiteSmoke;
            this.buttonBackSpace.ForeColor = Color.WhiteSmoke;
            this.buttonDivide.ForeColor = Color.WhiteSmoke;
            this.buttonEquals.ForeColor = Color.WhiteSmoke;
            this.buttonMinus.ForeColor = Color.WhiteSmoke;
            this.buttonPlus.ForeColor = Color.WhiteSmoke;
            this.buttonMultiply.ForeColor = Color.WhiteSmoke;
            this.button11.ForeColor = Color.WhiteSmoke;
            this.label1.ForeColor = Color.WhiteSmoke;
            this.textBox1.ForeColor = Color.WhiteSmoke;
            this.radioSimple.ForeColor = Color.WhiteSmoke;
            this.radioButtonAdvanced.ForeColor = Color.WhiteSmoke;
            this.buttonPow.BackColor = Color.Black;
            this.buttonPlus.BackColor = Color.Black;
            this.buttonSqrt.BackColor = Color.Black;
            this.buttonMinus.BackColor = Color.Black;
            this.buttonMultiply.BackColor = Color.Black;
            this.buttonDivide.BackColor = Color.Black;
            this.buttonEquals.BackColor = Color.Black;
            this.buttonPoint.BackColor = Color.Black;
            this.button1.BackColor = Color.Black;
            this.button2.BackColor = Color.Black;
            this.button3.BackColor = Color.Black;
            this.button4.BackColor = Color.Black;
            this.button5.BackColor = Color.Black;
            this.button6.BackColor = Color.Black;
            this.button7.BackColor = Color.Black;
            this.button8.BackColor = Color.Black;
            this.button9.BackColor = Color.Black;
            this.buttonBackSpace.BackColor = Color.Black;
            this.button0.BackColor = Color.Black;
            this.button11.BackColor = Color.Black;
            this.label1.BackColor = Color.Black;
        }
        // Button Clear
        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            txtBoxContent = textBox1.Text;
            txtBoxContent = txtBoxContent.Remove(txtBoxContent.Length - 1);
            textBox1.Text = txtBoxContent;
            labelContent = label1.Text;
            labelContent = labelContent.Remove(labelContent.Length - 1);
            label1.Text = labelContent;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            this.Calculations();
            this.currentSign = '√';
            this.label1.Text = "√";

        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            this.Calculations();
            this.currentSign = '^';
            this.label1.Text += "^";
            this.textBox1.Text = "";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ",";
            this.label1.Text += ",";
        }

        private void radioSimple_CheckedChanged(object sender, EventArgs e)
        {
            this.Width -= 66;
            this.buttonPow.Enabled = false;
            this.buttonSqrt.Enabled = false;

        }

        private void radioButtonAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            this.Width = 364;
            this.buttonSqrt.Enabled = true;
            this.buttonPow.Enabled = true;
        }
    }

}
