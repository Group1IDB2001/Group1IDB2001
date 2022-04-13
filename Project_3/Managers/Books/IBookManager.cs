using Project_3.Models.Entity;

namespace Project_3.Managers.Books
{
    public interface IBookManager
    {
        //ICollection<Book> GetAll();
        public IEnumerable<Book> ShowTenBooks(int PageNumber); //  Возвращает 1 страницу (10 обьектов Book) из всего каталога с указанным номером


        public IEnumerable<Book> SelectBooksByAuthor(int PageNumber, int AuthorID); // Возвращает 1 страницу Book с указанным AuthorID
        

        public IEnumerable<Book> SelectBooksByGenre(int PageNumber, int GenreID); // Возвращает 1 страницу Book с указанным GenreID


        public IEnumerable<Book> SelectBooksByType(int PageNumber, int TypeID); // Возвращает 1 страницу Book с указанным TypeID


        public IEnumerable<Book> SelectBooksByLanguage(int PageNumber, int LanguageID); // Возвращает 1 страницу Book с указанным LanguageID


        public IEnumerable<Book> SelectBooksByCountry(int PageNumber, int CountryID); // Возвращает 1 страницу Book с указанным CountryID


        public IEnumerable<Book> SortBooksByYearAscending(int PageNumber); // Возвращает 1 страницу Book , отсортированных по году издания в порядке возрастания


        public IEnumerable<Book> SortBooksByYearDescending(int PageNumber); // Возвращает 1 страницу Book , отсортированных по году издания в порядке убывания
        
    }
}
