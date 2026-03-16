using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
namespace StudioAssistant
{
    public partial class frmHome : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SortableBindingList<Artist> Artists { get; set; }
        private bool isDirty = false; // Flag to track unsaved changes
        private string currentFilePath = null; // To track the current file path for saving/loading
        public frmHome()
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
            bool hasArtistData = Artists.Count > 0; // Check if there are any artists in the list
            // Enable or disable buttons based on the state of the Artists list
            //btnSave.Enabled = isDirty; // Enable Save button if there are unsaved changes
            //btnDelete.Enabled = Artists.Count > 0; // Enable Delete button if there are artists in the list
        }

        private void lblArtist_Click(object sender, EventArgs e)
        {
            ArtistSelection artistSelectionForm = new ArtistSelection();
            artistSelectionForm.ShowDialog();

        }

        private void btn_newArtist_Click(object sender, EventArgs e)
        {
            var ArtistIntakeForm = new frm_ArtistIntake();

            if (ArtistIntakeForm.ShowDialog() == DialogResult.OK)
            {
                Artists.Add(ArtistIntakeForm.GetArtist());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvArtists.DataSource = Artists;
        }

        private void btn_selectArtist_Click(object sender, EventArgs e)
        {
            //load the selected artist and open the workflo form
            if (dgvArtists.CurrentRow != null)
            {
                Artist selectedArtist = dgvArtists.CurrentRow.DataBoundItem as Artist;
                if (selectedArtist != null)
                {
                    var WorkFlowForm = new WorkFlowForm(selectedArtist);
                    WorkFlowForm.ShowDialog();
                }
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            //Save the artists to a file using serialization, write a CSV file for now.
            if (Artists.Count == 0 || Artists == null)
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
                                $"{Escape(artist.MemberNames)}," +  //This will need to be updated to handle multiple member names in the future, for now it will just call ToString on the list which will give us the count of members and not the actual names, but this is just a placeholder for now until we implement the functionality for multiple members.
                                $"{Escape(artist.ContactEmail)}," +
                                $"{Escape(artist.ContactPhone)}";
                    writer.WriteLine(line);
                }
            }
            SetDirty(false); // Reset the dirty flag after saving
        }
    }
}
