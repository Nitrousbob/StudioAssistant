namespace StudioAssistant
{
    public partial class ArtistForm : Form
    {
        private Artist _artist; // Field to hold the artist data
        public ArtistForm()
        {
            InitializeComponent();
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
            this.Validate(); // Trigger validation for the form controls
            // Save the data from the form controls back to the artist object
            //after saving close the form and return DialogResult.OK to indicate that the artist was saved successfully
            //open the workflow form for the artist

            if (Validators.ContainsValue(txtArtistName.Text) == false)
            {
                MessageBox.Show("Please enter an Artist name.");
                return;
            }
            //does the form have a Contact name?
            if (Validators.ContainsValue(txtContactFirstName.Text) == false)
            {
                MessageBox.Show("Please enter a contact first name.");
                return;
            }

            //does the form have a Contact name?
            if (Validators.ContainsValue(txtContactLastName.Text) == false)
            {
                MessageBox.Show("Please enter a contact last name.");
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
                    MessageBox.Show("Please enter a valid email address. (ex. taco@toast.com)");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
