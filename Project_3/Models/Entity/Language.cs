namespace Project_3.Models.Entity
{
    public class Language
    {
        public Guid LanguageID { get; set; }
        public string LanguageName { get; set; }
        public Language(string Name)
        {
            LanguageID = Guid.NewGuid();
            LanguageName = Name;
        }

    }
}
