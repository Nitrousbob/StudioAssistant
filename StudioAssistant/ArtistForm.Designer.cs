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
            Contact = new DataGridViewCheckBoxColumn();
            FName = new DataGridViewTextBoxColumn();
            LName = new DataGridViewTextBoxColumn();
            Instrument = new DataGridViewTextBoxColumn();
            btnAddMember = new Button();
            txtContactFirstName = new Label();
            txtContactLastName = new Label();
            cbTextPreferred = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.BackColor = Color.DarkOrange;
            lblArtistName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtistName.Location = new Point(159, 22);
            lblArtistName.Margin = new Padding(2, 0, 2, 0);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(95, 20);
            lblArtistName.TabIndex = 8;
            lblArtistName.Text = "Artist Name";
            // 
            // txtArtistName
            // 
            txtArtistName.BackColor = Color.White;
            txtArtistName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArtistName.Location = new Point(258, 19);
            txtArtistName.Margin = new Padding(2);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(297, 27);
            txtArtistName.TabIndex = 0;
            // 
            // lblContactFirstName
            // 
            lblContactFirstName.AutoSize = true;
            lblContactFirstName.BackColor = Color.DarkOrange;
            lblContactFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblContactFirstName.Location = new Point(13, 257);
            lblContactFirstName.Margin = new Padding(2, 0, 2, 0);
            lblContactFirstName.Name = "lblContactFirstName";
            lblContactFirstName.Size = new Size(144, 20);
            lblContactFirstName.TabIndex = 10;
            lblContactFirstName.Text = "Contact First Name";
            // 
            // txtContactEmail
            // 
            txtContactEmail.BackColor = Color.White;
            txtContactEmail.Font = new Font("Segoe UI", 11.25F);
            txtContactEmail.Location = new Point(70, 314);
            txtContactEmail.Margin = new Padding(2);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.Size = new Size(297, 27);
            txtContactEmail.TabIndex = 3;
            txtContactEmail.Text = "name@provider.com";
            // 
            // lblContactEmail
            // 
            lblContactEmail.AutoSize = true;
            lblContactEmail.BackColor = Color.DarkOrange;
            lblContactEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblContactEmail.Location = new Point(13, 321);
            lblContactEmail.Margin = new Padding(2, 0, 2, 0);
            lblContactEmail.Name = "lblContactEmail";
            lblContactEmail.Size = new Size(47, 20);
            lblContactEmail.TabIndex = 12;
            lblContactEmail.Text = "Email";
            // 
            // txtContactPhone
            // 
            txtContactPhone.BackColor = Color.White;
            txtContactPhone.Font = new Font("Segoe UI", 11.25F);
            txtContactPhone.Location = new Point(70, 345);
            txtContactPhone.Margin = new Padding(2);
            txtContactPhone.Name = "txtContactPhone";
            txtContactPhone.Size = new Size(170, 27);
            txtContactPhone.TabIndex = 4;
            // 
            // lblContactPhone
            // 
            lblContactPhone.AutoSize = true;
            lblContactPhone.BackColor = Color.DarkOrange;
            lblContactPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblContactPhone.Location = new Point(13, 352);
            lblContactPhone.Margin = new Padding(2, 0, 2, 0);
            lblContactPhone.Name = "lblContactPhone";
            lblContactPhone.Size = new Size(53, 20);
            lblContactPhone.TabIndex = 13;
            lblContactPhone.Text = "Phone";
            // 
            // dtpContactDate
            // 
            dtpContactDate.CalendarMonthBackground = Color.White;
            dtpContactDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpContactDate.Format = DateTimePickerFormat.Custom;
            dtpContactDate.Location = new Point(70, 377);
            dtpContactDate.Margin = new Padding(2);
            dtpContactDate.MinDate = new DateTime(2026, 3, 15, 0, 0, 0, 0);
            dtpContactDate.Name = "dtpContactDate";
            dtpContactDate.Size = new Size(170, 27);
            dtpContactDate.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.DarkOrange;
            lblDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDate.Location = new Point(13, 384);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 20);
            lblDate.TabIndex = 14;
            lblDate.Text = "Date";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(687, 288);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(687, 322);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblContactLastName
            // 
            lblContactLastName.AutoSize = true;
            lblContactLastName.BackColor = Color.DarkOrange;
            lblContactLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblContactLastName.Location = new Point(13, 288);
            lblContactLastName.Margin = new Padding(2, 0, 2, 0);
            lblContactLastName.Name = "lblContactLastName";
            lblContactLastName.Size = new Size(142, 20);
            lblContactLastName.TabIndex = 11;
            lblContactLastName.Text = "Contact Last Name";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMembers.BackgroundColor = Color.DarkOrange;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { Contact, FName, LName, Instrument });
            dgvMembers.Location = new Point(6, 51);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(767, 150);
            dgvMembers.TabIndex = 15;
            dgvMembers.CellValueChanged += dgvMembers_CellValueChanged;
            dgvMembers.CurrentCellDirtyStateChanged += dgvMembers_CurrentCellDirtyStateChanged;
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
            // btnAddMember
            // 
            btnAddMember.Font = new Font("Segoe UI", 12F);
            btnAddMember.Location = new Point(687, 207);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(86, 27);
            btnAddMember.TabIndex = 16;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += button1_Click;
            // 
            // txtContactFirstName
            // 
            txtContactFirstName.BackColor = Color.White;
            txtContactFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtContactFirstName.Font = new Font("Segoe UI", 11.25F);
            txtContactFirstName.Location = new Point(197, 250);
            txtContactFirstName.Name = "txtContactFirstName";
            txtContactFirstName.Size = new Size(170, 27);
            txtContactFirstName.TabIndex = 17;
            txtContactFirstName.Text = "Contact First Name";
            // 
            // txtContactLastName
            // 
            txtContactLastName.BackColor = Color.White;
            txtContactLastName.BorderStyle = BorderStyle.FixedSingle;
            txtContactLastName.Font = new Font("Segoe UI", 11.25F);
            txtContactLastName.Location = new Point(196, 281);
            txtContactLastName.Name = "txtContactLastName";
            txtContactLastName.Size = new Size(170, 27);
            txtContactLastName.TabIndex = 18;
            txtContactLastName.Text = "Contact Last Name";
            // 
            // cbTextPreferred
            // 
            cbTextPreferred.AutoSize = true;
            cbTextPreferred.BackColor = Color.DarkOrange;
            cbTextPreferred.Location = new Point(258, 351);
            cbTextPreferred.Name = "cbTextPreferred";
            cbTextPreferred.Size = new Size(98, 19);
            cbTextPreferred.TabIndex = 20;
            cbTextPreferred.Text = "Text Preferred";
            cbTextPreferred.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(791, 433);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvMembers);
            panel2.Controls.Add(btnAddMember);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(cbTextPreferred);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(lblArtistName);
            panel2.Controls.Add(txtContactLastName);
            panel2.Controls.Add(txtArtistName);
            panel2.Controls.Add(dtpContactDate);
            panel2.Controls.Add(txtContactFirstName);
            panel2.Controls.Add(lblContactFirstName);
            panel2.Controls.Add(lblContactEmail);
            panel2.Controls.Add(txtContactPhone);
            panel2.Controls.Add(lblContactPhone);
            panel2.Controls.Add(txtContactEmail);
            panel2.Controls.Add(lblContactLastName);
            panel2.Controls.Add(lblDate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 421);
            panel2.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(258, 377);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 27);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(6, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 27);
            panel3.TabIndex = 21;
            // 
            // ArtistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 433);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ArtistForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Artist Form";
            Load += ArtistForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}