namespace Project_3.Models.Entity
{
    public class Tag
    {
        public Guid TagID { get; set; }
        public string TagName { get; set; }
        public string? TagDescription { get; set; }
        public Guid UserID  { get; set; }
    }
}
