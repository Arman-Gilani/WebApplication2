namespace WebApplication2.Models
{
    public class StateModel
    {
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string StateName { get; set; } = string.Empty;
        public string StateCode { get; set; } = string.Empty;    
    }
}
