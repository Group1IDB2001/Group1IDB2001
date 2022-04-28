namespace Project_3.Models.Entity
{
    public class Qestion
    {
        public Guid QestionID { get; set; }
        public Guid UserID { get; set; }
        public string qestiontext { get; set; }
        public Qestion (Guid User,string text)
        {
            QestionID = Guid.NewGuid();
            UserID = User;
            qestiontext = text; 

        }
    }
}
