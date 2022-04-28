namespace Project_3.Models.Entity
{
    public class Country
    {
        public Guid CountryID { get; set; }
        public string CountryName { get; set; }
        public Country (string Name)
        {
            CountryID = Guid.NewGuid();
            CountryName = Name;
        }
    }
}
