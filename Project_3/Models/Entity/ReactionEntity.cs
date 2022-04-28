namespace Project_3.Models.Entity
{
    public class ReactionEntity
    {
        public Guid ReactionEntityID { get; set; }
        public Guid ReactionId { get; set; }
        public Guid EntityID { get; set; }
        public int EntityType { get; set; }
        public ReactionEntity(Guid Reaction,Guid Entity,int Type)
        {
            ReactionEntityID = Guid.NewGuid();
            ReactionId = Reaction;
            EntityID = Entity;
            EntityType = Type;
        }
    }
}
