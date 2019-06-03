namespace CityKataDesign
{
    public class PoliticalArea
    {
        public PoliticalArea(string partyName, string gouvernor, List<string> meetings)
        {
            PartyName = partyName;
            Gouvernor = gouvernor;
            Meetings = meetings;
        }
        public string PartyName {get; set;}
        public string Gouvernor {get; set;}
        public List<string> Meetings {get; set;}

        //report
    }
}