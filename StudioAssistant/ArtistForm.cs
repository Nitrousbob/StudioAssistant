namespace StudioAssistant
{
    public partial class ArtistForm : Form
    {
        private Artist _artist; // Field to hold the artist data
        public ArtistForm()
        {
            InitializeComponent();
            dgvMembers.AutoGenerateColumns = false; // We will define columns manually
            dgvMembers.RowHeadersVisible = false;
            _artist = new Artist();
        }

        public void LoadArtist(Artist artist)
        {
            // Create a new instance so we don't edit the main list directly yet
            _artist = new Artist(
                artist.ArtistName,
                artist.ContactFirstName,
                artist.ContactLastName,
                artist.ContactEmail,
                artist.ContactPhone
            );

            _artist.Members.Clear(); // Clear any existing members in the new instance

            foreach (var m in artist.Members)
            {
                _artist.Members.Add(new Member(m.FName, m.LName, m.Instrument, m.IsPrimaryContact));
            }

            dgvMembers.DataSource = _artist.Members;  // Bind the members list to the DataGridView
        }

        public Artist GetArtist()
        {
            return _artist;  // Return the artist data from the form controls
        }

        private void ArtistForm_Load(object sender, EventArgs e)
        {
            // Load the artist data into the form controls
            txtArtistName.DataBindings.Add("Text", _artist, "ArtistName");

            txtContactFirstName.DataBindings.Add("Text", _artist, "ContactFirstName");
            txtContactLastName.DataBindings.Add("Text", _artist, "ContactLastName");

            txtContactEmail.DataBindings.Add("Text", _artist, "ContactEmail");
            txtContactPhone.DataBindings.Add("Text", _artist, "ContactPhone");
            dtpContactDate.DataBindings.Add("Value", _artist, "ContactDate");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.Validate(); // Trigger validation for the form controls
            dgvMembers.EndEdit(); // Ensure any edits in the DataGridView are committed to the data source

            if (Validators.ContainsValue(txtArtistName.Text) == false) //At least need an artist name to save the form
            {
                MessageBox.Show("Please enter an Artist name.");
                return;
            }

            //does the form have an email address or a phone number?
            if (Validators.ContainsValue(txtContactEmail.Text) == false &&
                Validators.ContainsValue(txtContactPhone.Text) == false)
            {
                MessageBox.Show("Please enter either an email address or a phone number.");
                return;
            }

            //check the pattern of email using regex
            if (Validators.ContainsValue(txtContactEmail.Text) == true)
            {
                if (Validators.IsValidEmail(txtContactEmail.Text) == false)
                {
                    MessageBox.Show("Please enter a valid email address. (ex. brutaltaco@metaltoast.com)");
                    return;
                }
            }

            //this.Validate(); // Trigger validation for the form controls
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvMembers.EndEdit(); // Ensure any edits in the DataGridView are committed to the data source
            _artist.Members.Add(new Member("New", "Member", "Instrument"));
        }

        //I had issues with CellValueChanged getting a null reference exception when trying to access because of the PrimaryContact Checkbox.
        private void dgvMembers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMembers.Columns[e.ColumnIndex].DataPropertyName == "IsPrimaryContact")
            {
                var member = (Member)dgvMembers.Rows[e.RowIndex].DataBoundItem;
                if (member == null) return; // Safety check

                if (member.IsPrimaryContact)
                {
                    // 1. Uncheck everyone else
                    foreach (var m in _artist.Members)
                    {
                        if (m != member) m.IsPrimaryContact = false;
                    }

                    // 2. Update the Artist object
                    _artist.ContactFirstName = member.FName;
                    _artist.ContactLastName = member.LName;

                    // 3. Safety Guard: Only refresh if bindings exist
                    if (txtContactFirstName.DataBindings.Count > 0)
                    {
                        txtContactFirstName.DataBindings[0].ReadValue();
                    }

                    if (txtContactLastName.DataBindings.Count > 0)
                    {
                        txtContactLastName.DataBindings[0].ReadValue();
                    }

                    dgvMembers.Invalidate();
                }
            }
        }

        private void dgvMembers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMembers.IsCurrentCellDirty)
            {
                dgvMembers.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

