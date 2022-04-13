using System;
using System.Collections.Generic;

namespace Project_3.Models.Entity
{
    public partial class Book
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public Guid AuthorID { get; set; }

        public List<Guid> GenreID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };

        public List<Guid> TagID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") };
        public int? Year { get; set; }
        public Guid CoverID { get; set; }
        public List<Guid> TypeID = new List<Guid>() { Guid.Parse("00000000-0000-0000-0000-00000000") }; // "00000000-0000-0000-0000-00000000"
        public Guid LanguageID  { get; set; }
        public Guid? CountryID { get; set; }
        public Guid? DataID  { get; set; }
        public string? aboutBook { get; set; }

    }
}
