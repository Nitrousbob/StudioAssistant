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
            this.Paint += new PaintEventHandler(Form1_Paint);
            Artists = new SortableBindingList<Artist>
            {
                AllowNew = true,
                AllowRemove = true,
                AllowEdit = false,
            };

            Artists.ListChanged += Artists_ListChanged;
            UpdateButtonState();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // If this works, your whole form turns Dark Grey and 
            // a Red circle appears where your mouse is.
            //e.Graphics.Clear(Color.FromArgb(30, 30, 30));
            //e.Graphics.FillEllipse(Brushes.Red, 50, 50, 100, 100);
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
            btnDelete.Enabled = Artists.Count > 0; // Enable Delete button if there are artists in the list
        }

        

        private void btnNewArtist_Click(object sender, EventArgs e)
        {
            ArtistForm artistForm = new ArtistForm();

            if (artistForm.ShowDialog() == DialogResult.OK)
            {
                Artist artist = artistForm.GetArtist();
                //Debug Message
                //MessageBox.Show(artist.ToString());
                Artists.Add(artist);
            }
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {

            var selectedArtist = dgvArtists.CurrentRow?.DataBoundItem as Artist;

            if (selectedArtist == null)
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
                    //Console.WriteLine(Artists[0].ArtistName);
                    //dgvArtists.Refresh();
                    //SetDirty(true);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvArtists.AutoGenerateColumns = false;
            dgvArtists.DataSource = Artists;
           
        }

        private void dgvArtists_SelectionChanged(object sender, EventArgs e)
        {
            //check if selected item is valid and enable/disable the Edit button accordingly
            var selectedArtist = dgvArtists.CurrentRow?.DataBoundItem as Artist;
            if (selectedArtist != null)
            {
                lblStaticArtist.Text = selectedArtist.ArtistName;
            } else
            {
                lblStaticArtist.Text = "Artist";
            }

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

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save Artist List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;

                using (var writer = new StreamWriter(filePath))
                {
                    // Write the header
                    writer.WriteLine("ArtistName,ContactFirstName,ContactLastName,ContactEmail,ContactPhone,ContactDate");
                    // Write each customer as a line in the CSV
                    foreach (var artist in Artists)
                    {
                        string Escape(string field)
                        {
                            if (field == null) return "\"\"";
                            return $"\"{field.Replace("\"", "\"\"")}\""; // Escape quotes by doubling them and wrap the field in quotes
                        }

                        //Apply the Escape function to each field to ensure proper formatting in the CSV
                        var line = $"{Escape(artist.ArtistName)}," +
                                   $"{Escape(artist.ContactFirstName)}," +
                                   $"{Escape(artist.ContactLastName)}," +
                                   $"{Escape(artist.ContactEmail)}," +
                                   $"{Escape(artist.ContactPhone)}," +
                                   $"{Escape(artist.ContactDate.ToString("o"))}"; // Use ISO 8601 format for date
                        writer.WriteLine(line);
                    }
                }
            }
            PerformActualSave(currentFilePath);
        }

        private void PerformActualSave(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Write the header
                writer.WriteLine("ArtistName,ContactFirstName,ContactLastName,ContactEmail,ContactPhone,ContactDate");
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
                               $"{Escape(artist.ContactFirstName)}," +
                               $"{Escape(artist.ContactLastName)}," +
                               $"{Escape(artist.ContactEmail)}," +
                               $"{Escape(artist.ContactPhone)}," +
                               $"{Escape(artist.ContactDate.ToString("o"))}"; // Use ISO 8601 format for date
                    writer.WriteLine(line);
                }
            }
            SetDirty(false); // Reset the dirty flag after saving
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Load the artists from a file,
            //read a CSV file with the Artist List
            if (Artists.Count > 0)
            {
                var result = MessageBox.Show(
                    "Loading a new artist list will replace the current list.\n Do you want to continue?",
                    "Confirm Load",
                    MessageBoxButtons.YesNo
                    );

                if (result == DialogResult.No)
                {
                    return; // Exit the loop and proceed with loading
                }

            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Load Artist List"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                Artists.RaiseListChangedEvents = false; // Temporarily disable events to prevent multiple UI updates
                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        Artists.Clear(); // Clear existing customers before loading new ones
                        string line;
                        bool isFirstLine = true; // Flag to skip the header line
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (isFirstLine)
                            {
                                isFirstLine = false; // Skip the header line
                                continue;
                            }
                            var parts = line.Split(',');
                            if (parts.Length == 6)
                            {
                                var artist = new Artist
                                {
                                    ArtistName = parts[0].Trim('"').Replace("\"\"", "\""), // Remove surrounding quotes and unescape any double quotes
                                    ContactFirstName = parts[1].Trim('"').Replace("\"\"", "\""),
                                    ContactLastName = parts[2].Trim('"').Replace("\"\"", "\""),
                                    ContactEmail = parts[3].Trim('"').Replace("\"\"", "\""),
                                    ContactPhone = parts[4].Trim('"').Replace("\"\"", "\""),
                                    ContactDate = DateTime.TryParse(parts[5].Trim('"').Replace("\"\"", "\""), out var date) ? date : DateTime.MinValue
                                };
                            Artists.Add(artist);
                            }
                        }
                    }
                currentFilePath = openFileDialog.FileName; // Update the current file path after loading
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}");
                }
                finally
                {
                    Artists.RaiseListChangedEvents = true; // Re-enable events after loading
                    Artists.ResetBindings(); // Refresh the UI after loading
                    SetDirty(false); // Reset the dirty flag after loading
                }
            }
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

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            //get the selected artist
            var selectedArtist = dgvArtists.CurrentRow?.DataBoundItem as Artist;

            if (selectedArtist == null)

            {
                MessageBox.Show("Please select an artist to delete.");
                return;
            }

            //always ask for confirmation before deleting data!
            var result = MessageBox.Show(
                $"Are you sure you want to delete {selectedArtist.ArtistName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Artists.Remove(selectedArtist);
                //The binding list will automatically update the DataGridView
                //when an item is removed, so we don't need to manually refresh it.
            }
}
    }
}
