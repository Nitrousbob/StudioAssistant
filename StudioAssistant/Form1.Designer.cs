namespace StudioAssistant
{
    partial class frmHome
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
            btn_selectArtist = new Button();
            btn_newArtist = new Button();
            dgvArtists = new DataGridView();
            artistBindingSource = new BindingSource(components);
            btnSaveAll = new Button();
            artistNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            lblStaticArtist.Location = new Point(93, 9);
            lblStaticArtist.Name = "lblStaticArtist";
            lblStaticArtist.Size = new Size(91, 38);
            lblStaticArtist.TabIndex = 2;
            lblStaticArtist.Text = "Artist";
            // 
            // btn_selectArtist
            // 
            btn_selectArtist.Location = new Point(12, 50);
            btn_selectArtist.Name = "btn_selectArtist";
            btn_selectArtist.Size = new Size(149, 34);
            btn_selectArtist.TabIndex = 3;
            btn_selectArtist.Text = "Select Artist";
            btn_selectArtist.UseVisualStyleBackColor = true;
            btn_selectArtist.Click += btn_selectArtist_Click;
            // 
            // btn_newArtist
            // 
            btn_newArtist.Location = new Point(167, 50);
            btn_newArtist.Name = "btn_newArtist";
            btn_newArtist.Size = new Size(149, 34);
            btn_newArtist.TabIndex = 4;
            btn_newArtist.Text = "New Artist";
            btn_newArtist.UseVisualStyleBackColor = true;
            btn_newArtist.Click += btn_newArtist_Click;
            // 
            // dgvArtists
            // 
            dgvArtists.AutoGenerateColumns = false;
            dgvArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtists.Columns.AddRange(new DataGridViewColumn[] { artistNameDataGridViewTextBoxColumn, memberNameDataGridViewTextBoxColumn, contactEmailDataGridViewTextBoxColumn, contactPhoneDataGridViewTextBoxColumn, contactDateDataGridViewTextBoxColumn });
            dgvArtists.DataSource = artistBindingSource;
            dgvArtists.Location = new Point(12, 99);
            dgvArtists.Name = "dgvArtists";
            dgvArtists.RowHeadersVisible = false;
            dgvArtists.RowHeadersWidth = 62;
            dgvArtists.Size = new Size(1004, 274);
            dgvArtists.TabIndex = 5;
            // 
            // artistBindingSource
            // 
            artistBindingSource.DataSource = typeof(Artist);
            // 
            // btnSaveAll
            // 
            btnSaveAll.Location = new Point(867, 379);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(149, 34);
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
            // memberNameDataGridViewTextBoxColumn
            // 
            memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            memberNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            memberNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            contactEmailDataGridViewTextBoxColumn.HeaderText = "ContactEmail";
            contactEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            contactEmailDataGridViewTextBoxColumn.ReadOnly = true;
            contactEmailDataGridViewTextBoxColumn.Width = 300;
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
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 420);
            Controls.Add(btnSaveAll);
            Controls.Add(dgvArtists);
            Controls.Add(btn_newArtist);
            Controls.Add(btn_selectArtist);
            Controls.Add(lblStaticArtist);
            Name = "frmHome";
            Text = "Studio Assistant";
            ((System.ComponentModel.ISupportInitialize)dgvArtists).EndInit();
            ((System.ComponentModel.ISupportInitialize)artistBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStaticArtist;
        private Button btn_selectArtist;
        private Button btn_newArtist;
        private DataGridView dgvArtists;
        private BindingSource artistBindingSource;
        private Button btnSaveAll;
        private DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDateDataGridViewTextBoxColumn;
    }
}
