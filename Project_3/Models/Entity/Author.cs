

using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }  

        public List<Guid> BookID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };

        public List<Guid> GenreID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };
        public Guid TagID { get; set; }
        public Guid LanguageID { get; set; }
        public Guid CountryID { get; set; }
        public string? aboutAuthor { get; set; }

    }
}
