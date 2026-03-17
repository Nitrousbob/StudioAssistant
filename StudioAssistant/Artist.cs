using System.ComponentModel;

namespace StudioAssistant
{
    public class Artist
    {
        public string ArtistName { get; set; }
        public BindingList<Member> Members { get; set; } = new BindingList<Member>();

        //primary contact fields
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
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
            ContactDate = DateTime.Now;
            Members = new BindingList<Member>();  //initialize the list so its ready to use
        }

        //overloaded constructor
        public Artist(string name, string fName, string lName, string email, string phone)
        {
            ArtistName = name;
            ContactFirstName = fName;
            ContactLastName = lName;
            ContactEmail = email;
            ContactPhone = phone;
            ContactDate = DateTime.Now;
            Members = new BindingList<Member>();
        }


        public override string ToString()
        {
            string members = Members.Count > 0 ? string.Join(", ", Members) : "None";
            return $"Artist: {ArtistName} | Members: {members} | Contact: {ContactName}";
        }  //added string.Join to list the member names
    }
}
