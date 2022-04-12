using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public List<int> AuthorID = new List<int>() { 0 };

        public List<int> BookID = new List<int>() { 0 };


    }
}
