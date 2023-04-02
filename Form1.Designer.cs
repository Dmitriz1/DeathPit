namespace DeathPit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hpProgressBar = new ProgressBar();
            hpLabel = new Label();
            SuspendLayout();
            // 
            // hpProgressBar
            // 
            hpProgressBar.BackColor = Color.LimeGreen;
            hpProgressBar.ForeColor = Color.RosyBrown;
            hpProgressBar.Location = new Point(602, 12);
            hpProgressBar.Name = "hpProgressBar";
            hpProgressBar.Size = new Size(186, 20);
            hpProgressBar.TabIndex = 0;
            // 
            // hpLabel
            // 
            hpLabel.AutoSize = true;
            hpLabel.Location = new Point(565, 12);
            hpLabel.Name = "hpLabel";
            hpLabel.Size = new Size(31, 20);
            hpLabel.TabIndex = 1;
            hpLabel.Text = "HP:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hpLabel);
            Controls.Add(hpProgressBar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar hpProgressBar;
        private Label hpLabel;
    }
}