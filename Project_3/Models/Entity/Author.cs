

using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }  

        public List<int> BookID = new List<int>() { 0 };

        public List<int> GenreID = new List<int>() { 0 };
        public int TagID { get; set; }
        public int LanguageID { get; set; }
        public int CountryID { get; set; }
        public string? aboutAuthor { get; set; }

    }
}
