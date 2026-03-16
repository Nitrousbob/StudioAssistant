namespace StudioAssistant
{
    partial class frm_ArtistIntake
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
            lblArtistName = new Label();
            txtArtistName = new TextBox();
            txtMemberName = new TextBox();
            lblMemberName = new Label();
            txtContactEmail = new TextBox();
            lblContactEmail = new Label();
            txtContactPhone = new TextBox();
            lblContactPhone = new Label();
            dtpContactDate = new DateTimePicker();
            lblDate = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtistName.Location = new Point(12, 18);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(115, 25);
            lblArtistName.TabIndex = 0;
            lblArtistName.Text = "Artist Name";
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(172, 12);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(466, 31);
            txtArtistName.TabIndex = 1;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(172, 49);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(466, 31);
            txtMemberName.TabIndex = 3;
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemberName.Location = new Point(12, 55);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(138, 25);
            lblMemberName.TabIndex = 2;
            lblMemberName.Text = "Member Name";
            // 
            // txtContactEmail
            // 
            txtContactEmail.Location = new Point(172, 86);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.Size = new Size(466, 31);
            txtContactEmail.TabIndex = 5;
            txtContactEmail.Text = "name@provider.com";
            // 
            // lblContactEmail
            // 
            lblContactEmail.AutoSize = true;
            lblContactEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactEmail.Location = new Point(12, 92);
            lblContactEmail.Name = "lblContactEmail";
            lblContactEmail.Size = new Size(58, 25);
            lblContactEmail.TabIndex = 4;
            lblContactEmail.Text = "Email";
            // 
            // txtContactPhone
            // 
            txtContactPhone.Location = new Point(172, 123);
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.Size = new Size(241, 31);
            txtContactPhone.TabIndex = 7;
            // 
            // lblContactPhone
            // 
            lblContactPhone.AutoSize = true;
            lblContactPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactPhone.Location = new Point(12, 129);
            lblContactPhone.Name = "lblContactPhone";
            lblContactPhone.Size = new Size(66, 25);
            lblContactPhone.TabIndex = 6;
            lblContactPhone.Text = "Phone";
            // 
            // dtpContactDate
            // 
            dtpContactDate.Format = DateTimePickerFormat.Custom;
            dtpContactDate.Location = new Point(172, 160);
            dtpContactDate.MinDate = new DateTime(2026, 3, 15, 0, 0, 0, 0);
            dtpContactDate.Name = "dtpContactDate";
            dtpContactDate.Size = new Size(241, 31);
            dtpContactDate.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(12, 166);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 25);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(526, 164);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(526, 124);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frm_ArtistIntake
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 224);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblDate);
            Controls.Add(dtpContactDate);
            Controls.Add(txtContactPhone);
            Controls.Add(lblContactPhone);
            Controls.Add(txtContactEmail);
            Controls.Add(lblContactEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lblMemberName);
            Controls.Add(txtArtistName);
            Controls.Add(lblArtistName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ArtistIntake";
            Text = "ArtistIntake";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArtistName;
        private TextBox txtArtistName;
        private TextBox txtMemberName;
        private Label lblMemberName;
        private TextBox txtContactEmail;
        private Label lblContactEmail;
        private TextBox txtContactPhone;
        private Label lblContactPhone;
        private DateTimePicker dtpContactDate;
        private Label lblDate;
        private Button btnSave;
        private Button btnCancel;
    }
}