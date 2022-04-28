namespace Project_3.Models.Entity
{
    
    public class ItemLanguage
    {
        public Guid ItemLanguageIDd { get; set; }
        public Guid ItemID { get; set; }
        public Guid LanguageID { get; set; }
        public ItemLanguage (Guid Item,Guid Language)
        {
            ItemLanguageIDd = Guid.NewGuid();
            ItemLanguageIDd = Item;
            LanguageID = Language;
        }
    }
}
