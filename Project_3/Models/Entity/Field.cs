namespace Project_3.Models.Entity
{
    public class Field
    {
        public int FieldID { get; set; }
        public string FieldName { get; set; }

        public List<int> AuthorID = new List<int>() { 0 };

        public List<int> BookID = new List<int>() { 0 };
    }
}
