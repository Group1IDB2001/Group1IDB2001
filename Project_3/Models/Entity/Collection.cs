namespace Project_3.Models.Entity
{
    public class Collection
    {
        public Guid CollectionID { get; set; }
        public string CollectionName { get; set; }
        public string CollectionDescription { get; set; }
        public Guid UserID { get; set; }
    }
}
