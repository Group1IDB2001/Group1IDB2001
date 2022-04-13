namespace Project_3.Models.Entity
{
    public class Tag
    {
        public Guid TagID { get; set; }
        public string TagName { get; set; }

        public List<int> AuthorID = new List<int>() { 0 };

        public List<int> BookID = new List<int>() { 0 };
    }
}
