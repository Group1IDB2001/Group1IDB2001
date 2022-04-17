

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

    }
}
