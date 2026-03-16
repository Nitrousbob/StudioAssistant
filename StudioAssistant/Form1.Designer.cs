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
            components = new System.ComponentModel.Container();
            lblStaticArtist = new Label();
            btnEditArtist = new Button();
            btn_newArtist = new Button();
            dgvArtists = new DataGridView();
            artistBindingSource = new BindingSource(components);
            btnSaveAll = new Button();
            artistNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ContactEmail = new DataGridViewTextBoxColumn();
            contactPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvArtists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)artistBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblStaticArtist
            // 
            lblStaticArtist.AutoSize = true;
            lblStaticArtist.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaticArtist.Location = new Point(65, 5);
            lblStaticArtist.Margin = new Padding(2, 0, 2, 0);
            lblStaticArtist.Name = "lblStaticArtist";
            lblStaticArtist.Size = new Size(61, 25);
            lblStaticArtist.TabIndex = 2;
            lblStaticArtist.Text = "Artist";
            // 
            // btnEditArtist
            // 
            btnEditArtist.Location = new Point(8, 30);
            btnEditArtist.Margin = new Padding(2);
            btnEditArtist.Name = "btnEditArtist";
            btnEditArtist.Size = new Size(104, 20);
            btnEditArtist.TabIndex = 3;
            btnEditArtist.Text = "Edit Artist";
            btnEditArtist.UseVisualStyleBackColor = true;
            btnEditArtist.Click += btnEditArtist_Click;
            // 
            // btn_newArtist
            // 
            btn_newArtist.Location = new Point(117, 30);
            btn_newArtist.Margin = new Padding(2);
            btn_newArtist.Name = "btn_newArtist";
            btn_newArtist.Size = new Size(104, 20);
            btn_newArtist.TabIndex = 4;
            btn_newArtist.Text = "New Artist";
            btn_newArtist.UseVisualStyleBackColor = true;
            btn_newArtist.Click += btn_newArtist_Click;
            // 
            // dgvArtists
            // 
            dgvArtists.AutoGenerateColumns = false;
            dgvArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtists.Columns.AddRange(new DataGridViewColumn[] { artistNameDataGridViewTextBoxColumn, contactEmailDataGridViewTextBoxColumn, ContactEmail, contactPhoneDataGridViewTextBoxColumn, contactDateDataGridViewTextBoxColumn });
            dgvArtists.DataSource = artistBindingSource;
            dgvArtists.Location = new Point(8, 59);
            dgvArtists.Margin = new Padding(2);
            dgvArtists.Name = "dgvArtists";
            dgvArtists.RowHeadersVisible = false;
            dgvArtists.RowHeadersWidth = 62;
            dgvArtists.Size = new Size(853, 164);
            dgvArtists.TabIndex = 5;
            // 
            // artistBindingSource
            // 
            artistBindingSource.DataSource = typeof(Artist);
            // 
            // btnSaveAll
            // 
            btnSaveAll.Location = new Point(712, 227);
            btnSaveAll.Margin = new Padding(2);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(104, 20);
            btnSaveAll.TabIndex = 6;
            btnSaveAll.Text = "Save All";
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            artistNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            artistNameDataGridViewTextBoxColumn.ReadOnly = true;
            artistNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactFirstName";
            contactEmailDataGridViewTextBoxColumn.HeaderText = "Contact Name";
            contactEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            contactEmailDataGridViewTextBoxColumn.ReadOnly = true;
            contactEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // ContactEmail
            // 
            ContactEmail.DataPropertyName = "ContactEmail";
            ContactEmail.HeaderText = "ContactEmail";
            ContactEmail.Name = "ContactEmail";
            ContactEmail.Width = 200;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            contactPhoneDataGridViewTextBoxColumn.HeaderText = "ContactPhone";
            contactPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            contactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            contactPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactDateDataGridViewTextBoxColumn
            // 
            contactDateDataGridViewTextBoxColumn.DataPropertyName = "ContactDate";
            contactDateDataGridViewTextBoxColumn.HeaderText = "ContactDate";
            contactDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            contactDateDataGridViewTextBoxColumn.Name = "contactDateDataGridViewTextBoxColumn";
            contactDateDataGridViewTextBoxColumn.ReadOnly = true;
            contactDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 252);
            Controls.Add(btnSaveAll);
            Controls.Add(dgvArtists);
            Controls.Add(btn_newArtist);
            Controls.Add(btnEditArtist);
            Controls.Add(lblStaticArtist);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Studio Assistant";
            ((System.ComponentModel.ISupportInitialize)dgvArtists).EndInit();
            ((System.ComponentModel.ISupportInitialize)artistBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStaticArtist;
        private Button btnEditArtist;
        private Button btn_newArtist;
        private DataGridView dgvArtists;
        private BindingSource artistBindingSource;
        private Button btnSaveAll;
        private DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ContactEmail;
        private DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDateDataGridViewTextBoxColumn;
    }
}
