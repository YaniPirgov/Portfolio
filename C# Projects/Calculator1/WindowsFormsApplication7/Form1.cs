using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class appCalculator : Form
    {
        public appCalculator()
        {
            InitializeComponent();
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains(','))
                        throw X;
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void textB_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains('.'))
                        throw X;
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "1";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "1"; 
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "2";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "2";
            };
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "3";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "4";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "5";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "6";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "7";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "8";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "9";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + "0";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textA.Enabled = false;
            btnPoint.Enabled = true;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (textA.Enabled == true)
            {
                textA.Text = textA.Text + ".";
            }
            else if (textA.Enabled == false)
            {
                textB.Text = textB.Text + ".";
            }
            btnPoint.Enabled = false;
        }

        private void btnRav_Click(object sender, EventArgs e)
        {
            double A = 0, B = 0, C=0;
            A = Convert.ToDouble(textA.Text);
            B = Convert.ToDouble(textB.Text);
            if (btnRav.Enabled == true)
            {
                C = A + B;
                textResh.Text = C.ToString();
            }
        }

    }
}