namespace LabyrinthEscapeAI
{
    partial class LabyrinthForm
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
            this.labyrinthPanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.episodesLabel = new System.Windows.Forms.Label();
            this.episodesCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labyrinthPanel
            // 
            this.labyrinthPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labyrinthPanel.Location = new System.Drawing.Point(12, 12);
            this.labyrinthPanel.Name = "labyrinthPanel";
            this.labyrinthPanel.Size = new System.Drawing.Size(501, 501);
            this.labyrinthPanel.TabIndex = 0;
            this.labyrinthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.labyrinthPanel_Paint);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(519, 12);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 2;
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Location = new System.Drawing.Point(518, 13);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(53, 13);
            this.episodesLabel.TabIndex = 3;
            this.episodesLabel.Text = "Episodes:";
            // 
            // episodesCountLabel
            // 
            this.episodesCountLabel.AutoSize = true;
            this.episodesCountLabel.Location = new System.Drawing.Point(577, 13);
            this.episodesCountLabel.Name = "episodesCountLabel";
            this.episodesCountLabel.Size = new System.Drawing.Size(0, 13);
            this.episodesCountLabel.TabIndex = 4;
            // 
            // LabyrinthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 540);
            this.Controls.Add(this.episodesCountLabel);
            this.Controls.Add(this.episodesLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.labyrinthPanel);
            this.Name = "LabyrinthForm";
            this.Text = "Labyrinth";
            this.Load += new System.EventHandler(this.LabyrinthForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabyrinthForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel labyrinthPanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label episodesLabel;
        private System.Windows.Forms.Label episodesCountLabel;
    }
}

