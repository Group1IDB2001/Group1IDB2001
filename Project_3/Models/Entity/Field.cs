namespace Project_3.Models.Entity
{
    public class Field
    {
        public Guid FieldID { get; set; }
        public string FieldName { get; set; }

        public List<Guid> AuthorID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };

        public List<Guid> BookID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };
    }
}
