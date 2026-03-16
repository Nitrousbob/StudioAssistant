using System.ComponentModel;
namespace StudioAssistant
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SortableBindingList<Artist> Artists { get; set; }
        private bool isDirty = false; // Flag to track unsaved changes
        private string currentFilePath = null; // To track the current file path for saving/loading
        public Form1()
        {
            InitializeComponent();

            Artists = new SortableBindingList<Artist>
            {
                AllowNew = true,
                AllowRemove = true,
                AllowEdit = false,
            };

            Artists.ListChanged += Artists_ListChanged;
            UpdateButtonState();
        }

        private void SetDirty(bool dirty)
        {
            if (dirty != isDirty)
            {
                isDirty = dirty;
                btnSaveAll.Text = isDirty ? "Save*" : "Save";
                //update the button to show that there are unsaved changes
            }
        }

        private void Artists_ListChanged(object sender, ListChangedEventArgs e)
        {
            SetDirty(true);
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            bool hasData = Artists.Count > 0; // Check if there are any artists in the list
            // Enable or disable buttons based on the state of the Artists list
            btnSaveAll.Enabled = hasData; // Enable Save button if there are unsaved changes
            //btnDelete.Enabled = Artists.Count > 0; // Enable Delete button if there are artists in the list
        }

        private void btn_newArtist_Click(object sender, EventArgs e)
        {
            var newArtistForm = new ArtistForm();

            if (newArtistForm.ShowDialog() == DialogResult.OK)
            {
                Artists.Add(newArtistForm.GetArtist());
            }
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            var selectedArtist = dgvArtists.CurrentRow?.DataBoundItem as Artist;

            if(selectedArtist == null)
            {
                MessageBox.Show("Please select or create an Artist to edit.");
                return;
            }

            using (var artistForm = new ArtistForm())
            {
                artistForm.LoadArtist(selectedArtist);

                if (artistForm.ShowDialog() == DialogResult.OK)
                {
                    var updated = artistForm.GetArtist();

                    // Map the values back to the original object in the list
                    selectedArtist.ArtistName = updated.ArtistName;
                    selectedArtist.ContactFirstName = updated.ContactFirstName;
                    selectedArtist.ContactLastName = updated.ContactLastName;
                    selectedArtist.ContactEmail = updated.ContactEmail;
                    selectedArtist.ContactPhone = updated.ContactPhone;

                    // Update UI
                    Artists.ResetBindings();
                    Console.WriteLine(Artists[0].ArtistName);
                    dgvArtists.Refresh();
                    SetDirty(true);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvArtists.DataSource = Artists;
        }

        private void dgvArtists_SelectionChanged(object sender, EventArgs e)
        {
            //check if selected item is valid and enable/disable the Edit button accordingly
            var selectedArtist = dgvArtists.CurrentRow?.DataBoundItem as Artist;
            btnEditArtist.Enabled = selectedArtist != null;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            //Save the artists to a file using serialization, write a CSV file for now.
            if (Artists == null || Artists.Count == 0)  //check null before checking count to avoid null reference exception
            {
                MessageBox.Show("No artists to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check if the current file path is set
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    Title = "Save Artists"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else
                {
                    return; // User cancelled the save operation
                }
            }

            //Performe actual save operation here, write the artists to the file path using CSV format
        }
        private void PerformActualSave(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Write the header
                writer.WriteLine("FirstName,LastName,Email,Phone");
                // Write each artist as a line in the CSV
                foreach (var artist in Artists)
                {
                    string Escape(string field)
                    {
                        if (field == null) return "\"\"";
                        return $"\"{field.Replace("\"", "\"\"")}\""; // Escape quotes by doubling them and wrap the field in quotes
                    }

                    //Apply the Escape function to each field to ensure proper formatting in the CSV
                    var line = $"{Escape(artist.ArtistName)}," +
                                //$"{Escape(artist.MemberNames)}," +  //This will need to be updated to handle multiple member names in the future, for now it will just call ToString on the list which will give us the count of members and not the actual names, but this is just a placeholder for now until we implement the functionality for multiple members.
                                $"{Escape(artist.ContactEmail)}," +
                                $"{Escape(artist.ContactPhone)}";
                    writer.WriteLine(line);
                }
            }
            SetDirty(false); // Reset the dirty flag after saving
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                var result = MessageBox.Show(this, "You have unsaved changes. Would you like to save before exiting?",
                                             "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    btnSaveAll_Click(sender, e); // Trigger your save logic
                                                 // If they cancel out of the save dialog, we should cancel the close
                    if (isDirty) e.Cancel = true;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Don't close the app
                }
            }
        }
    }
}
