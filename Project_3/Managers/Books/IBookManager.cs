using Project_3.Models.Entity;

namespace Project_3.Managers.Books
{
    public interface IBookManager<T> where T : class //In order to deal with any kind
    {

        //function that returns data of a specific type
        public IEnumerable<T> GetAll();

        //function returns a single element of a given type so that the identifier is not associated with a given type
        T GetById(Object id);

        //A function that adds an element of a certain type
        void Insert(T entity);
        
        //A function that updates an element of a certain type
        void Update(T entity);

        //A function that deletes an element of a certain type
        void Delete(object id);




        ////ICollection<Book> GetAll();
        //public IEnumerable<Book> ShowTenBooks(int PageNumber); //  Возвращает 1 страницу (10 обьектов Book) из всего каталога с указанным номером


        //public IEnumerable<Book> SelectBooksByAuthor(int PageNumber, int AuthorID); // Возвращает 1 страницу Book с указанным AuthorID
        

        //public IEnumerable<Book> SelectBooksByGenre(int PageNumber, int GenreID); // Возвращает 1 страницу Book с указанным GenreID


        //public IEnumerable<Book> SelectBooksByType(int PageNumber, int TypeID); // Возвращает 1 страницу Book с указанным TypeID


        //public IEnumerable<Book> SelectBooksByLanguage(int PageNumber, int LanguageID); // Возвращает 1 страницу Book с указанным LanguageID


        //public IEnumerable<Book> SelectBooksByCountry(int PageNumber, int CountryID); // Возвращает 1 страницу Book с указанным CountryID


        //public IEnumerable<Book> SortBooksByYearAscending(int PageNumber); // Возвращает 1 страницу Book , отсортированных по году издания в порядке возрастания


        //public IEnumerable<Book> SortBooksByYearDescending(int PageNumber); // Возвращает 1 страницу Book , отсортированных по году издания в порядке убывания
        
    }
}
