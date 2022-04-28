namespace Project_3.Models.Entity
{
    public class AuthorCountry
    {
        public Guid AuthorCountryID { get; set; }
        public Guid AuthorID { get; set; }
        public Guid CountryID { get; set; }
        public AuthorCountry (Guid Author,Guid Country)
        {
            AuthorCountryID = Guid.NewGuid();
            AuthorID = Author;
            CountryID = Country;
        }
    }
}
