using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            _artist = artist;
        }

        public Artist GetArtist()
        {
            return _artist;
        }

        private void ArtistIntake_Load(object sender, EventArgs e)
        {
            // Load the artist data into the form controls
            txtArtistName.Text = _artist.ArtistName;
            txtMemberName.Text = _artist.MemberName;
            txtContactEmail.Text = _artist.ContactEmail;
            txtContactPhone.Text = _artist.ContactPhone;
            dtpContactDate.Value = _artist.ContactDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the data from the form controls back to the artist object
            //after saving close the form and return DialogResult.OK to indicate that the artist was saved successfully
            //open the workflow form for the artist
        }
    }
}
