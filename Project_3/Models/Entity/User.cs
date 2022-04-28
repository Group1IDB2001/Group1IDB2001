namespace Project_3.Models.Entity
{
    public class User
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }

        public User (string Name,string Password,string Mail,int R)
        {
            UserID = Guid.NewGuid();
            UserName = Name;
            this.Password = Password;
            Email = Mail;
            Role = R;
        }
    }
}
