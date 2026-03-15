namespace StudioAssistant
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            lblStudioAssistant = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblStudioAssistant
            // 
            lblStudioAssistant.AutoSize = true;
            lblStudioAssistant.Font = new Font("Segoe UI", 39F);
            lblStudioAssistant.Location = new Point(99, 164);
            lblStudioAssistant.Name = "lblStudioAssistant";
            lblStudioAssistant.Size = new Size(588, 104);
            lblStudioAssistant.TabIndex = 0;
            lblStudioAssistant.Text = "Studio Assistant";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStudioAssistant);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudioAssistant;
        private System.Windows.Forms.Timer timer1;
    }
}