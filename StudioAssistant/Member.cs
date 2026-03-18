namespace StudioAssistant
{

    public class Member
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Instrument { get; set; }  //What is the members primary instrument?
        public bool IsPrimaryContact { get; set; }  //This property is for setting the primary Contact
        public string FullName => $"{FName} {LName}";

        //parameterless constructor for filling in boxes of an empty object for the JSON serializer
        public Member() 
        {
                FName = "";
                LName = "";
                Instrument = "";
                IsPrimaryContact = false;
        }

        public Member(string fName, string lName, string instrument, bool isContact = false)
        {
            FName = fName;
            LName = lName;
            Instrument = instrument;
            IsPrimaryContact = isContact;
        }
    }
}
