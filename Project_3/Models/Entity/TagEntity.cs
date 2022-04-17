namespace Project_3.Models.Entity
{
    enum EntityType
    {
        NoInfo = 0,
        Item = 1,
        Author = 2,
        Collection = 3
    }

public class TagEntity
    {
        public Guid TagEntityId { get; set; }
        public Guid EntityID { get; set; }
        public int EntityType { get; set; }
        public Guid TagID { get; set; }
    }
}
