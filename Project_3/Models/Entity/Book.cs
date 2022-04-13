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
        public List<int> TypeID = new List<int>() { 0 };
        public int LanguageID  { get; set; }
        public int? CountryID { get; set; }
        public int? DataID  { get; set; }
        public string? aboutBook { get; set; }

        public IEnumerable<Book> ShowTenBooks(int PageNumber) //  Возвращает 1 страницу (10 обьектов Book) из всего каталога с указанным номером
        {
            IEnumerable < Book > Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SelectBooksByAuthor (int PageNumber,int AuthorID) // Возвращает 1 страницу Book с указанным AuthorID
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SelectBooksByGenre(int PageNumber, int GenreID) // Возвращает 1 страницу Book с указанным GenreID
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SelectBooksByType(int PageNumber, int TypeID) // Возвращает 1 страницу Book с указанным TypeID
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SelectBooksByLanguage(int PageNumber, int LanguageID) // Возвращает 1 страницу Book с указанным LanguageID
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SelectBooksByCountry(int PageNumber, int CountryID) // Возвращает 1 страницу Book с указанным CountryID
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SortBooksByYearAscending(int PageNumber) // Возвращает 1 страницу Book , отсортированных по году издания в порядке возрастания
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SortBooksByYearDescending(int PageNumber) // Возвращает 1 страницу Book , отсортированных по году издания в порядке убывания
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }


    }
}
