namespace Project_3.Models.Entity
{
    public class Tag
    {
        public Guid TagID { get; set; }
        public string TagName { get; set; }
        public string? TagDescription { get; set; }
        public Guid UserID  { get; set; }
        public Tag (string Name,string Description,Guid User)
        {
            TagID = Guid.NewGuid ();
            TagName = Name;
            TagDescription = Description;
            UserID = User;
        }
    }
}
