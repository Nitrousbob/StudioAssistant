using System.ComponentModel;
using System.Text.Json;
using System.IO;
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
                    selectedArtist.Members = updated.Members;

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
            if (Artists == null || Artists.Count == 0)
            {
                MessageBox.Show("No artists to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If we don't have a path yet, ask the user
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON files (*.json)|*.json",
                    Title = "Save Artist List"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else return; // User cancelled
            }

            // Now we have a guaranteed path, perform the save
            PerformActualSave(currentFilePath);
        }

        private void PerformActualSave(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) return;

            try
            {
                // Options to make the file "human readable" with indents
                var options = new JsonSerializerOptions { WriteIndented = true };

                // This one line replaces your entire loop and Escape function!
                string jsonString = JsonSerializer.Serialize(Artists, options);

                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save Error: {ex.Message}");
            }

            SetDirty(false); // Reset the dirty flag after saving
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (Artists.Count > 0)
            {
                var result = MessageBox.Show("Loading will replace the current list. Continue?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Load Artist List"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    var loadedArtists = JsonSerializer.Deserialize<List<Artist>>(jsonString);

                    if (loadedArtists != null)
                    {
                        Artists.RaiseListChangedEvents = false;
                        Artists.Clear();
                        foreach (var a in loadedArtists) Artists.Add(a);

                        currentFilePath = openFileDialog.FileName;
                        Artists.RaiseListChangedEvents = true;
                        Artists.ResetBindings();
                        SetDirty(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading JSON: {ex.Message}");
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
