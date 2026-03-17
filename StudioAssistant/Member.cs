namespace StudioAssistant
{

    public class Member
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Instrument { get; set; }

        public string FullName => $"{FName} {LName}";

        public Member(string fName, string lName, string instrument)
        {
            FName = fName;
            LName = lName;
            Instrument = instrument;
        }

    }
}
