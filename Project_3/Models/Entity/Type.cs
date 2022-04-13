namespace Project_3.Models.Entity
{
    public class Type
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }

        public List<int> AuthorID = new List<int>() { 0 };

        public List<int> BookID = new List<int>() { 0 };
    }
}
