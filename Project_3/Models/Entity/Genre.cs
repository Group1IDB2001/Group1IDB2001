using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public class Genre
    {
        public Guid GenreID { get; set; }
        public string GenreName { get; set; }

        public List<Guid> AuthorID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };

        public List<int> BookID = new List<int>() { 0 };


    }
}
