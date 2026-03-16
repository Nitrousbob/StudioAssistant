using System;
using System.Collections.Generic;
using System.Text;

namespace StudioAssistant
{
    public class Artist
    {
        public string ArtistName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        //make a list for multiple members in the future
        public List<string> MemberNames { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime ContactDate { get; set; }

        //build some artists to put into the list for testing

        public Artist(string name, string fName, string lName, string email, string phone)
        {
            ArtistName = name;
            ContactFirstName = fName;
            ContactLastName = lName;
            ContactEmail = email;
            ContactPhone = phone;
            ContactDate = DateTime.Now;
        }

        public Artist()
        {
            ArtistName = "";
            MemberNames = new List<string>();
            ContactFirstName = "";
            ContactLastName = "";
            ContactEmail = "";
            ContactPhone = "";
            ContactDate = DateTime.Now;
        }

        public override string ToString() {
            return $"Artist Name: {ArtistName}, Contact Name: {ContactFirstName} {ContactLastName}, Contact Email: {ContactEmail}, Contact Phone: {ContactPhone}, Contact Date: {ContactDate}";
        }
    }
}
