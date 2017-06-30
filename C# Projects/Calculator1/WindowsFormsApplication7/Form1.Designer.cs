namespace WindowsFormsApplication7
{
    partial class appCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textResh = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKoren = new System.Windows.Forms.Button();
            this.btnKvadrat = new System.Windows.Forms.Button();
            this.btnPo = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRav = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(12, 12);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 20);
            this.textA.TabIndex = 0;
            this.textA.TextChanged += new System.EventHandler(this.textA_TextChanged);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(132, 12);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 20);
            this.textB.TabIndex = 1;
            this.textB.TextChanged += new System.EventHandler(this.textB_TextChanged);
            // 
            // textResh
            // 
            this.textResh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textResh.Location = new System.Drawing.Point(12, 38);
            this.textResh.Name = "textResh";
            this.textResh.ReadOnly = true;
            this.textResh.Size = new System.Drawing.Size(220, 20);
            this.textResh.TabIndex = 2;
            this.textResh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 126);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(23, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(41, 126);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(23, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(70, 126);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(23, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(202, 64);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 25);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKoren
            // 
            this.btnKoren.Location = new System.Drawing.Point(166, 126);
            this.btnKoren.Name = "btnKoren";
            this.btnKoren.Size = new System.Drawing.Size(30, 25);
            this.btnKoren.TabIndex = 9;
            this.btnKoren.Text = "√";
            this.btnKoren.UseVisualStyleBackColor = true;
            // 
            // btnKvadrat
            // 
            this.btnKvadrat.Location = new System.Drawing.Point(202, 126);
            this.btnKvadrat.Name = "btnKvadrat";
            this.btnKvadrat.Size = new System.Drawing.Size(30, 25);
            this.btnKvadrat.TabIndex = 8;
            this.btnKvadrat.Text = "x²";
            this.btnKvadrat.UseVisualStyleBackColor = true;
            // 
            // btnPo
            // 
            this.btnPo.Location = new System.Drawing.Point(166, 95);
            this.btnPo.Name = "btnPo";
            this.btnPo.Size = new System.Drawing.Size(30, 25);
            this.btnPo.TabIndex = 11;
            this.btnPo.Text = "X";
            this.btnPo.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(202, 95);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(30, 25);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "/";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnRav
            // 
            this.btnRav.Location = new System.Drawing.Point(166, 157);
            this.btnRav.Name = "btnRav";
            this.btnRav.Size = new System.Drawing.Size(66, 23);
            this.btnRav.TabIndex = 12;
            this.btnRav.Text = "=";
            this.btnRav.UseVisualStyleBackColor = true;
            this.btnRav.Click += new System.EventHandler(this.btnRav_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(70, 66);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(23, 23);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(41, 66);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(23, 23);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 66);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(23, 23);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(70, 95);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(23, 23);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(41, 95);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(23, 23);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 95);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(23, 23);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 155);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 23);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(70, 155);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(23, 23);
            this.btnPoint.TabIndex = 20;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // appCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 262);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnRav);
            this.Controls.Add(this.btnPo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnKoren);
            this.Controls.Add(this.btnKvadrat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textResh);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Name = "appCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textResh;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKoren;
        private System.Windows.Forms.Button btnKvadrat;
        private System.Windows.Forms.Button btnPo;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRav;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
    }
}

