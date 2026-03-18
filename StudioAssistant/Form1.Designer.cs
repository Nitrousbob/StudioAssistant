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
            colArtistName = new DataGridViewTextBoxColumn();
            colContactName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colLastContacted = new DataGridViewTextBoxColumn();
            btnSaveAll = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvArtists).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblStaticArtist
            // 
            lblStaticArtist.BackColor = Color.DarkOrange;
            lblStaticArtist.Dock = DockStyle.Top;
            lblStaticArtist.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaticArtist.Location = new Point(0, 0);
            lblStaticArtist.Margin = new Padding(2, 0, 2, 0);
            lblStaticArtist.Name = "lblStaticArtist";
            lblStaticArtist.Size = new Size(924, 52);
            lblStaticArtist.TabIndex = 2;
            lblStaticArtist.Text = "Artist";
            lblStaticArtist.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditArtist
            // 
            btnEditArtist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditArtist.BackColor = Color.White;
            btnEditArtist.Enabled = false;
            btnEditArtist.Font = new Font("Segoe UI", 12F);
            btnEditArtist.Location = new Point(97, 409);
            btnEditArtist.Margin = new Padding(2);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(70, 35);
            btnEditArtist.TabIndex = 3;
            btnEditArtist.Text = "Edit Artist";
            btnEditArtist.UseVisualStyleBackColor = false;
            btnEditArtist.Click += btnEditArtist_Click;
            // 
            // btnNewArtist
            // 
            btnNewArtist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewArtist.BackColor = Color.White;
            btnNewArtist.Font = new Font("Segoe UI", 12F);
            btnNewArtist.Location = new Point(23, 409);
            btnNewArtist.Margin = new Padding(2);
            btnNewArtist.Name = "btnNewArtist";
            btnNewArtist.Size = new Size(70, 35);
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
            dgvArtists.BackgroundColor = Color.DarkOrange;
            dgvArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtists.Columns.AddRange(new DataGridViewColumn[] { colArtistName, colContactName, colEmail, colPhone, colLastContacted });
            dgvArtists.GridColor = Color.Black;
            dgvArtists.Location = new Point(11, 59);
            dgvArtists.Margin = new Padding(2);
            dgvArtists.Name = "dgvArtists";
            dgvArtists.RowHeadersVisible = false;
            dgvArtists.RowHeadersWidth = 62;
            dgvArtists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtists.Size = new Size(912, 346);
            dgvArtists.TabIndex = 5;
            dgvArtists.CellDoubleClick += dgvArtists_CellDoubleClick;
            dgvArtists.SelectionChanged += dgvArtists_SelectionChanged;
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
            // btnSaveAll
            // 
            btnSaveAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAll.BackColor = Color.White;
            btnSaveAll.Font = new Font("Segoe UI", 12F);
            btnSaveAll.Location = new Point(695, 409);
            btnSaveAll.Margin = new Padding(2);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(104, 35);
            btnSaveAll.TabIndex = 6;
            btnSaveAll.Text = "Save All";
            btnSaveAll.UseVisualStyleBackColor = false;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoad.BackColor = Color.White;
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(803, 409);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 35);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(171, 409);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 35);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteArtist_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(934, 455);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblStaticArtist);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 445);
            panel2.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(663, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 19);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(7, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 19);
            panel3.TabIndex = 0;
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
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studio Assistant";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArtists).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
    }
}
