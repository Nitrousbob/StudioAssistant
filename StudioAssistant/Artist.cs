using System.ComponentModel;

namespace StudioAssistant
{
    public class Artist
    {
        public string ArtistName { get; set; }
        public SortableBindingList<Member> Members { get; set; }
        //primary contact fields
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public bool IsTextPreferred { get; set; }
        public DateTime ContactDate { get; set; }
        public string ContactName => $"{ContactFirstName} {ContactLastName}".Trim();

        //parameterless constructor for filling in boxes of an empty object
        public Artist()
        {
            ArtistName = "";
            ContactFirstName = "";
            ContactLastName = "";
            ContactEmail = "";
            ContactPhone = "";
            IsTextPreferred = false;
            ContactDate = DateTime.Now;
            Members = new SortableBindingList<Member>();  //initialize the list so its ready to use
        }

        //overloaded constructor
        public Artist(string name, string fName, string lName, string email, string phone, bool isText)
        {
            ArtistName = name;
            ContactFirstName = fName;
            ContactLastName = lName;
            ContactEmail = email;
            ContactPhone = phone;
            IsTextPreferred = isText;
            ContactDate = DateTime.Now;

            Members = new SortableBindingList<Member>();
        }


        public override string ToString()
        {
            string members = Members.Count > 0 ? string.Join(", ", Members) : "None";
            return $"Artist: {ArtistName} | Members: {members} | Contact: {ContactName}";
        }  //added string.Join to list the member names
    }
}
