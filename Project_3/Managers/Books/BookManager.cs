using Project_3.DAL;
using Project_3.Models.Entity;

namespace Project_3.Managers.Books
{
    public class BookManager:IBookManager
    {
        private LibraContext _context;

        public BookManager(LibraContext context)
        {
            _context = context;
        }

        //public ICollection<Book> GetAll()
        //{
        //    return _context.Books;
        //}

        public IEnumerable<Book> ShowTenBooks(int PageNumber) //  Возвращает 1 страницу (10 обьектов Book) из всего каталога с указанным номером
        {
            IEnumerable<Book> Page = new List<Book>();
            return Page;
        }

        public IEnumerable<Book> SelectBooksByAuthor(int PageNumber, int AuthorID) // Возвращает 1 страницу Book с указанным AuthorID
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
