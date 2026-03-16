namespace StudioAssistant
{

    public partial class WorkFlowForm : Form
    {
        private Artist selectedArtist; // Field to hold the selected artist data

        public WorkFlowForm(Artist selectedArtist)
        {
            this.selectedArtist = selectedArtist;
            InitializeComponent();
        }
    }
}
