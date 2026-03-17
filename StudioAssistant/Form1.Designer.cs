namespace StudioAssistant
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
            lblStaticArtist = new Label();
            btnEditArtist = new Button();
            btnNewArtist = new Button();
            dgvArtists = new DataGridView();
            btnSaveAll = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            colArtistName = new DataGridViewTextBoxColumn();
            colContactName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colLastContacted = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvArtists).BeginInit();
            SuspendLayout();
            // 
            // lblStaticArtist
            // 
            lblStaticArtist.Anchor = AnchorStyles.Top;
            lblStaticArtist.AutoSize = true;
            lblStaticArtist.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaticArtist.Location = new Point(389, 9);
            lblStaticArtist.Margin = new Padding(2, 0, 2, 0);
            lblStaticArtist.Name = "lblStaticArtist";
            lblStaticArtist.Size = new Size(93, 40);
            lblStaticArtist.TabIndex = 2;
            lblStaticArtist.Text = "Artist";
            lblStaticArtist.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEditArtist
            // 
            btnEditArtist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditArtist.Enabled = false;
            btnEditArtist.Location = new Point(97, 424);
            btnEditArtist.Margin = new Padding(2);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(70, 20);
            btnEditArtist.TabIndex = 3;
            btnEditArtist.Text = "Edit Artist";
            btnEditArtist.UseVisualStyleBackColor = true;
            btnEditArtist.Click += btnEditArtist_Click;
            // 
            // btnNewArtist
            // 
            btnNewArtist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewArtist.BackColor = SystemColors.Control;
            btnNewArtist.Location = new Point(23, 424);
            btnNewArtist.Margin = new Padding(2);
            btnNewArtist.Name = "btnNewArtist";
            btnNewArtist.Size = new Size(70, 20);
            btnNewArtist.TabIndex = 4;
            btnNewArtist.Text = "&New Artist";
            btnNewArtist.UseVisualStyleBackColor = false;
            btnNewArtist.Click += btnNewArtist_Click;
            // 
            // dgvArtists
            // 
            dgvArtists.AllowUserToAddRows = false;
            dgvArtists.AllowUserToResizeRows = false;
            dgvArtists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtists.BorderStyle = BorderStyle.Fixed3D;
            dgvArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtists.Columns.AddRange(new DataGridViewColumn[] { colArtistName, colContactName, colEmail, colPhone, colLastContacted });
            dgvArtists.Location = new Point(11, 59);
            dgvArtists.Margin = new Padding(2);
            dgvArtists.Name = "dgvArtists";
            dgvArtists.RowHeadersVisible = false;
            dgvArtists.RowHeadersWidth = 62;
            dgvArtists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtists.Size = new Size(915, 361);
            dgvArtists.TabIndex = 5;
            dgvArtists.CellDoubleClick += dgvArtists_CellDoubleClick;
            dgvArtists.SelectionChanged += dgvArtists_SelectionChanged;
            // 
            // btnSaveAll
            // 
            btnSaveAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAll.Location = new Point(695, 424);
            btnSaveAll.Margin = new Padding(2);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(104, 20);
            btnSaveAll.TabIndex = 6;
            btnSaveAll.Text = "Save All";
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoad.Location = new Point(803, 424);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 20);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(171, 424);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 20);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteArtist_Click;
            // 
            // colArtistName
            // 
            colArtistName.DataPropertyName = "ArtistName";
            colArtistName.HeaderText = "Artist";
            colArtistName.MinimumWidth = 150;
            colArtistName.Name = "colArtistName";
            colArtistName.Width = 150;
            // 
            // colContactName
            // 
            colContactName.DataPropertyName = "ContactName";
            colContactName.HeaderText = "Contact Name";
            colContactName.MinimumWidth = 200;
            colContactName.Name = "colContactName";
            colContactName.Width = 200;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.DataPropertyName = "ContactEmail";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 200;
            colEmail.Name = "colEmail";
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "ContactPhone";
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.Width = 150;
            // 
            // colLastContacted
            // 
            colLastContacted.DataPropertyName = "ContactDate";
            colLastContacted.HeaderText = "Last Contacted";
            colLastContacted.MinimumWidth = 120;
            colLastContacted.Name = "colLastContacted";
            colLastContacted.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(934, 455);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnSaveAll);
            Controls.Add(dgvArtists);
            Controls.Add(btnNewArtist);
            Controls.Add(btnEditArtist);
            Controls.Add(lblStaticArtist);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studio Assistant";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArtists).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStaticArtist;
        private Button btnEditArtist;
        private Button btnNewArtist;
        private DataGridView dgvArtists;
        private Button btnSaveAll;
        private Button btnLoad;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colArtistName;
        private DataGridViewTextBoxColumn colContactName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colLastContacted;
    }
}
