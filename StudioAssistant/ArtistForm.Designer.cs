namespace StudioAssistant
{
    partial class ArtistForm
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
            txtContactFirstName = new TextBox();
            lblContactFirstName = new Label();
            txtContactEmail = new TextBox();
            lblContactEmail = new Label();
            txtContactPhone = new TextBox();
            lblContactPhone = new Label();
            dtpContactDate = new DateTimePicker();
            lblDate = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtContactLastName = new TextBox();
            lblContactLastName = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtistName.Location = new Point(8, 11);
            lblArtistName.Margin = new Padding(2, 0, 2, 0);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(74, 15);
            lblArtistName.TabIndex = 8;
            lblArtistName.Text = "Artist Name";
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(150, 7);
            txtArtistName.Margin = new Padding(2);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(297, 23);
            txtArtistName.TabIndex = 0;
            // 
            // txtContactFirstName
            // 
            txtContactFirstName.Location = new Point(150, 444);
            txtContactFirstName.Margin = new Padding(2);
            txtContactFirstName.Name = "txtContactFirstName";
            txtContactFirstName.Size = new Size(170, 23);
            txtContactFirstName.TabIndex = 1;
            // 
            // lblContactFirstName
            // 
            lblContactFirstName.AutoSize = true;
            lblContactFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactFirstName.Location = new Point(8, 452);
            lblContactFirstName.Margin = new Padding(2, 0, 2, 0);
            lblContactFirstName.Name = "lblContactFirstName";
            lblContactFirstName.Size = new Size(113, 15);
            lblContactFirstName.TabIndex = 10;
            lblContactFirstName.Text = "Contact First Name";
            // 
            // txtContactEmail
            // 
            txtContactEmail.Location = new Point(150, 503);
            txtContactEmail.Margin = new Padding(2);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.Size = new Size(297, 23);
            txtContactEmail.TabIndex = 3;
            txtContactEmail.Text = "name@provider.com";
            // 
            // lblContactEmail
            // 
            lblContactEmail.AutoSize = true;
            lblContactEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactEmail.Location = new Point(8, 506);
            lblContactEmail.Margin = new Padding(2, 0, 2, 0);
            lblContactEmail.Name = "lblContactEmail";
            lblContactEmail.Size = new Size(36, 15);
            lblContactEmail.TabIndex = 12;
            lblContactEmail.Text = "Email";
            // 
            // txtContactPhone
            // 
            txtContactPhone.Location = new Point(150, 530);
            txtContactPhone.Margin = new Padding(2);
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.Size = new Size(170, 23);
            txtContactPhone.TabIndex = 4;
            // 
            // lblContactPhone
            // 
            lblContactPhone.AutoSize = true;
            lblContactPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactPhone.Location = new Point(8, 533);
            lblContactPhone.Margin = new Padding(2, 0, 2, 0);
            lblContactPhone.Name = "lblContactPhone";
            lblContactPhone.Size = new Size(42, 15);
            lblContactPhone.TabIndex = 13;
            lblContactPhone.Text = "Phone";
            // 
            // dtpContactDate
            // 
            dtpContactDate.Format = DateTimePickerFormat.Custom;
            dtpContactDate.Location = new Point(150, 557);
            dtpContactDate.Margin = new Padding(2);
            dtpContactDate.MinDate = new DateTime(2026, 3, 15, 0, 0, 0, 0);
            dtpContactDate.Name = "dtpContactDate";
            dtpContactDate.Size = new Size(170, 23);
            dtpContactDate.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(8, 561);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 14;
            lblDate.Text = "Date";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(702, 11);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(702, 35);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 20);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtContactLastName
            // 
            txtContactLastName.Location = new Point(150, 471);
            txtContactLastName.Margin = new Padding(2);
            txtContactLastName.Name = "txtContactLastName";
            txtContactLastName.Size = new Size(170, 23);
            txtContactLastName.TabIndex = 2;
            // 
            // lblContactLastName
            // 
            lblContactLastName.AutoSize = true;
            lblContactLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactLastName.Location = new Point(8, 479);
            lblContactLastName.Margin = new Padding(2, 0, 2, 0);
            lblContactLastName.Name = "lblContactLastName";
            lblContactLastName.Size = new Size(111, 15);
            lblContactLastName.TabIndex = 11;
            lblContactLastName.Text = "Contact Last Name";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 9;
            // 
            // ArtistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 589);
            Controls.Add(listBox1);
            Controls.Add(txtContactLastName);
            Controls.Add(lblContactLastName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblDate);
            Controls.Add(dtpContactDate);
            Controls.Add(txtContactPhone);
            Controls.Add(lblContactPhone);
            Controls.Add(txtContactEmail);
            Controls.Add(lblContactEmail);
            Controls.Add(txtContactFirstName);
            Controls.Add(lblContactFirstName);
            Controls.Add(txtArtistName);
            Controls.Add(lblArtistName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ArtistForm";
            Text = "ArtistIntake";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArtistName;
        private TextBox txtArtistName;
        private TextBox txtContactFirstName;
        private Label lblContactFirstName;
        private TextBox txtContactEmail;
        private Label lblContactEmail;
        private TextBox txtContactPhone;
        private Label lblContactPhone;
        private DateTimePicker dtpContactDate;
        private Label lblDate;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtContactLastName;
        private Label lblContactLastName;
        private ListBox listBox1;
    }
}