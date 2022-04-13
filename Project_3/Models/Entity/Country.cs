namespace Project_3.Models.Entity
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public List<int> AuthorID = new List<int>() { 0 };

        public List<int> BookID = new List<int>() { 0 };
    }
}
