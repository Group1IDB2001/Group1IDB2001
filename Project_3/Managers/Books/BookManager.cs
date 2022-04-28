using Project_3.DAL;
using Project_3.Models.Entity;

namespace Project_3.Managers.Books
{
    public class BookManager:IBookManager
    {
        private LibraryContext _context;

        public BookManager(LibraryContext context)
        {
            _context = context;
        }

        //public ICollection<Book> GetAll()
        //{
        //    return _context.Books;
        //}

        

        
    }
}
