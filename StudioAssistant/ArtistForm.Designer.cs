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
            lblContactFirstName = new Label();
            txtContactEmail = new TextBox();
            lblContactEmail = new Label();
            txtContactPhone = new TextBox();
            lblContactPhone = new Label();
            dtpContactDate = new DateTimePicker();
            lblDate = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblContactLastName = new Label();
            dgvMembers = new DataGridView();
            btnAddMember = new Button();
            txtContactFirstName = new Label();
            txtContactLastName = new Label();
            cbTextPreferred = new CheckBox();
            Contact = new DataGridViewCheckBoxColumn();
            FName = new DataGridViewTextBoxColumn();
            LName = new DataGridViewTextBoxColumn();
            Instrument = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtistName.Location = new Point(12, 7);
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
            btnSave.BackColor = SystemColors.Control;
            btnSave.Location = new Point(702, 11);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
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
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { Contact, FName, LName, Instrument });
            dgvMembers.Location = new Point(12, 88);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(767, 150);
            dgvMembers.TabIndex = 15;
            dgvMembers.CellValueChanged += dgvMembers_CellValueChanged;
            dgvMembers.CurrentCellDirtyStateChanged += dgvMembers_CurrentCellDirtyStateChanged;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(12, 244);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(75, 23);
            btnAddMember.TabIndex = 16;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += button1_Click;
            // 
            // txtContactFirstName
            // 
            txtContactFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtContactFirstName.Location = new Point(150, 451);
            txtContactFirstName.Name = "txtContactFirstName";
            txtContactFirstName.Size = new Size(170, 23);
            txtContactFirstName.TabIndex = 17;
            txtContactFirstName.Text = "Contact First Name";
            // 
            // txtContactLastName
            // 
            txtContactLastName.BorderStyle = BorderStyle.FixedSingle;
            txtContactLastName.Location = new Point(150, 478);
            txtContactLastName.Name = "txtContactLastName";
            txtContactLastName.Size = new Size(170, 22);
            txtContactLastName.TabIndex = 18;
            txtContactLastName.Text = "Contact Last Name";
            // 
            // cbTextPreferred
            // 
            cbTextPreferred.AutoSize = true;
            cbTextPreferred.Location = new Point(349, 529);
            cbTextPreferred.Name = "cbTextPreferred";
            cbTextPreferred.Size = new Size(98, 19);
            cbTextPreferred.TabIndex = 20;
            cbTextPreferred.Text = "Text Preferred";
            cbTextPreferred.UseVisualStyleBackColor = true;
            // 
            // Contact
            // 
            Contact.DataPropertyName = "IsPrimaryContact";
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.Width = 60;
            // 
            // FName
            // 
            FName.DataPropertyName = "FName";
            FName.HeaderText = "First Name";
            FName.Name = "FName";
            FName.Width = 150;
            // 
            // LName
            // 
            LName.DataPropertyName = "LName";
            LName.HeaderText = "Last Name";
            LName.Name = "LName";
            LName.Width = 150;
            // 
            // Instrument
            // 
            Instrument.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Instrument.DataPropertyName = "Instrument";
            Instrument.HeaderText = "Instrument";
            Instrument.Name = "Instrument";
            // 
            // ArtistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 589);
            Controls.Add(cbTextPreferred);
            Controls.Add(txtContactLastName);
            Controls.Add(txtContactFirstName);
            Controls.Add(btnAddMember);
            Controls.Add(dgvMembers);
            Controls.Add(lblContactLastName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblDate);
            Controls.Add(dtpContactDate);
            Controls.Add(txtContactPhone);
            Controls.Add(lblContactPhone);
            Controls.Add(txtContactEmail);
            Controls.Add(lblContactEmail);
            Controls.Add(lblContactFirstName);
            Controls.Add(txtArtistName);
            Controls.Add(lblArtistName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "ArtistForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Artist Form";
            Load += ArtistForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArtistName;
        private TextBox txtArtistName;
        private Label lblContactFirstName;
        private TextBox txtContactEmail;
        private Label lblContactEmail;
        private TextBox txtContactPhone;
        private Label lblContactPhone;
        private DateTimePicker dtpContactDate;
        private Label lblDate;
        private Button btnSave;
        private Button btnCancel;
        private Label lblContactLastName;
        private DataGridView dgvMembers;
        private Button btnAddMember;
        private Label txtContactFirstName;
        private Label txtContactLastName;
        private CheckBox cbTextPreferred;
        private DataGridViewCheckBoxColumn Contact;
        private DataGridViewTextBoxColumn FName;
        private DataGridViewTextBoxColumn LName;
        private DataGridViewTextBoxColumn Instrument;
    }
}