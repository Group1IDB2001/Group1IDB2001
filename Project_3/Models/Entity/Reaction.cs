namespace Project_3.Models.Entity
{
    public class Reaction
    {
        public Guid ReactionId { get; set; }
        public Guid UserID { get; set; }
        public Guid EntityID { get; set; }
        public int EntityType { get; set; }
        public string? comment { get; set; }
        public int? rating { get; set; }


    }
}
