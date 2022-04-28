namespace Project_3.Models.Entity
{
    public class ItemAuthor
    {
        public Guid ItemAuthorId { get; set; }
        public Guid AuthorID { get; set; }
        public Guid ItemID { get; set; }
        public ItemAuthor (Guid Author,Guid Item)
        {
            ItemAuthorId = Guid.NewGuid();
            AuthorID = Author;
            ItemID = Item;
        }
    }
}
