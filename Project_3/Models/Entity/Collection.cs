namespace Project_3.Models.Entity
{
    public class Collection
    {
        public Guid CollectionID { get; set; }
        public string CollectionName { get; set; }
        public string CollectionDescription { get; set; }
        public Guid UserID { get; set; }
        public Collection (string Name,Guid User)
        {
            CollectionID = Guid.NewGuid();
            CollectionName = Name;
            CollectionDescription = " ";
            UserID = User;
        }
        public Collection (string Name,string Description,Guid User)
        {
            CollectionID = Guid.NewGuid();
            CollectionName = Name;
            CollectionDescription = Description;
            UserID = User;
        }
    }
}
