

using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }  
        public int AuthorYearOfBorn { get; set; }
        public int AuthorStatus { get; set; }

        public int? AuthorYearOfDeath { get; set; }
        public string? AuthorDescription { get; set; }

        public Author (string Name,int Year1,int Status,int Year2)
        { 
            AuthorId = Guid.NewGuid();
            AuthorName = Name;
            AuthorYearOfBorn = Year1;
            AuthorStatus = Status;
            if (Status == 0)
                AuthorYearOfDeath = Year2;
        }
        public Author(string Name, int Year1, int Status, int Year2,string Description)
        {
            AuthorId = Guid.NewGuid();
            AuthorName = Name;
            AuthorYearOfBorn = Year1;
            AuthorStatus = Status;
            if (Status == 0)
                AuthorYearOfDeath = Year2;
            AuthorDescription = Description;
        }
    }
}
