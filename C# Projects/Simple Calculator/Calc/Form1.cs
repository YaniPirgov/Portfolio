using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbBox.SelectedItem == null)
            {
                MessageBox.Show("Fuck you!");
            }
            else
            {
                switch (cmbBox.SelectedItem.ToString())
                {
                    default:
                        MessageBox.Show("Невалидна операция");
                        break;
                    case "+":
                        txtBox3.Text = (int.Parse(txtBox1.Text) + int.Parse(txtBox2.Text)).ToString();
                        break;
                    case "-":
                        txtBox3.Text = (int.Parse(txtBox1.Text) - int.Parse(txtBox2.Text)).ToString();
                        break;
                    case "*":
                        txtBox3.Text = (int.Parse(txtBox1.Text) * int.Parse(txtBox2.Text)).ToString();
                        break;
                    case "/":
                        txtBox3.Text = (int.Parse(txtBox1.Text) / int.Parse(txtBox2.Text)).ToString();
                        break;
                }
            }
           
        }

        private void cmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label1.Text = cmbBox.SelectedItem.ToString(); 
        }
    }
}
