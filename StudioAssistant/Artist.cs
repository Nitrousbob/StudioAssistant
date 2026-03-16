using System;
using System.Collections.Generic;
using System.Text;

namespace StudioAssistant
{
    public class Artist
    {
        public string ArtistName { get; private set; }
        public string MemberName { get; private set; }
        //make a list for multiple members in the future
        public List<string> MemberNames { get; private set; }
        public string ContactEmail { get; private set; }
        public string ContactPhone { get; private set; }
        public DateTime ContactDate { get; private set; }

        //build some artists to put into the list for testing

        public Artist(string aName, List<string> memberNames, string email, string phone)
        {
            aName = ArtistName;
            
        }

        public Artist()
        {
            ArtistName = "";
            MemberNames = new List<string>();
            ContactEmail = "";
            ContactPhone = "";
            ContactDate = DateTime.Now;
        }

        public override string ToString() {
            return $"Artist Name: {ArtistName}, Member Name: {MemberNames[0]}, Contact Email: {ContactEmail}, Contact Phone: {ContactPhone}, Contact Date: {ContactDate}";
        }
    }
}
