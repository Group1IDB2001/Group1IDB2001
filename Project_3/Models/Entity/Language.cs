namespace Project_3.Models.Entity
{
    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        public List<int> AuthorID = new List<int>() { 0 };

        public List<int> BookID = new List<int>() { 0 };
    }
}
