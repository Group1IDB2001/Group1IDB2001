namespace Project_3.Models.Entity
{
    public class CollectionItem
    {
        public Guid CollectionItemID { get; set; }
        public Guid CollectionID { get; set; }
        public Guid ItemID  { get; set; }
        public CollectionItem (Guid Collection,Guid Item)
        {
            CollectionItemID = Guid.NewGuid();
            CollectionID = Collection;
            ItemID = Item;
        }
    }
}
