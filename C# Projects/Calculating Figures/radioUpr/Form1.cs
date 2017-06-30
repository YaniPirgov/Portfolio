using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioUpr
{
    public partial class Form1 : Form
    {
        int button = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Functional Methods

        public void ClearAll()
        {
            this.lice.Text = "";
            this.perimetar.Text = "";
            this.txtBox1.Text = "";
            this.txtBox2.Text = "";
            this.txtBox3.Text = "";

        }

        #endregion

        #region Event Handlers

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBox2.Hide();
            lblB.Hide();
            txtBox3.Hide();
            lblC.Hide();
            this.button = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtBox2.Show();
            txtBox3.Hide();
            lblC.Hide();
            lblB.Show();
            this.button = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtBox2.Show();
            lblB.Show();
            lblC.Show();
            txtBox3.Show();
            this.button = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            //
            //
            if(this.button==1)
            {
                int a = int.Parse(txtBox1.Text);
                perimetar.Text = (4 * a).ToString();
                lice.Text = (a * a).ToString();
            }

            if (this.button == 2)
            {
                int a = int.Parse(txtBox1.Text);
                int b = int.Parse(txtBox2.Text);
                perimetar.Text = (2*a + 2*b).ToString();
                lice.Text = (a * b).ToString();
            }
            if(this.button==3)
            {
                int a = int.Parse(txtBox1.Text);
                int b = int.Parse(txtBox2.Text);
               int c = int.Parse(txtBox3.Text);
                int p = (a + b + c);
               perimetar.Text =p.ToString();
               lice.Text = Math.Sqrt((p-a)*(p-b)*(p-c)).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
