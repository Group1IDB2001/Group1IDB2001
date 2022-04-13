namespace Project_3.Models.Entity
{
    public class Type
    {
        public Guid TypeID { get; set; }
        public string TypeName { get; set; }

        public List<Guid> AuthorID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };

        public List<int> BookID = new List<int>() { 0 };
    }
}
