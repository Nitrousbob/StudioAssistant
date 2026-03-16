using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudioAssistant
{
    public partial class frm_ArtistIntake : Form
    {
        private Artist _artist; // Field to hold the artist data
        public frm_ArtistIntake()
        {
            InitializeComponent();
            _artist = new Artist();
        }

        public void LoadArtist(Artist artist)
        {
            _artist = artist; // Load the artist data into the form controls
        }

        public Artist GetArtist()
        {
            return _artist;  // Return the artist data from the form controls
        }

        private void ArtistIntake_Load(object sender, EventArgs e)
        {
            // Load the artist data into the form controls
            txtArtistName.DataBindings.Add("Text", _artist, "FirstName");
            txtContactFirstName.DataBindings.Add("Text", _artist, "ContactFirstName");
            txtContactLastName.DataBindings.Add("Text", _artist, "ContactLastName");
            txtContactEmail.DataBindings.Add("Text", _artist, "ContactEmail");
            txtContactPhone.DataBindings.Add("Text", _artist, "ContactPhone");
            dtpContactDate.DataBindings.Add("Value", _artist, "ContactDate");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the data from the form controls back to the artist object
            //after saving close the form and return DialogResult.OK to indicate that the artist was saved successfully
            //open the workflow form for the artist
            
            if (Validators.ContainsValue(txtArtistName.Text) == false)
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }
            //does the form have a Contact name?
            if (Validators.ContainsValue(txtContactFirstName.Text) == false)
            {
                MessageBox.Show("Please enter one member name.");
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
