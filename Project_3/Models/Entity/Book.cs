using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int AuthorID { get; set; }

        public List<int> GenreID = new List<int>() { 0 };

        public List<int> TagID = new List<int>() { 0 };
        public int? Year { get; set; }
        public int CoverID { get; set; }
        public List<int> TypeID = new List<int>() { 0 }; // "00000000-0000-0000-0000-00000000"
        public int LanguageID  { get; set; }
        public int? CountryID { get; set; }
        public int? DataID  { get; set; }
        public string? aboutBook { get; set; }


    }
}
