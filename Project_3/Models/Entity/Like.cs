namespace Project_3.Models.Entity
{
    public class Like
    {
        public Guid LikeID { get; set; }
        public Guid UserID { get; set; }
        public Guid EntityID { get; set; }
        public int EntityType { get; set; }
        public Like (Guid User,Guid Entity,int Type)
        {
            LikeID=Guid.NewGuid();
            UserID=User;
            EntityID=Entity;
            EntityType=Type;
        }
    }
}
