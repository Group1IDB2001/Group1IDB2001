using Project_3.Controllers;
using Project_3.Models.Entity;

namespace Project_3.DAL
{
    public class LibraryContext
    {
        public List<Book> Books { get; set; } //= new List<Book>();
        public int LastBookCount;
        public List<Author> Authors { get; set; } //= new List<Author>();

        public List<Country> Countries { get; set; } //= new List<Country>();

        public List<Field> Fields { get; set; } //= new List<Field>();

        public List<Genre> Genres { get; set; } //= new List<Genre>();

        public List<Language> Languages { get; set; } //= new List<Language>();

        public List<Tag> Tags { get; set; } //= new List<Tag>();

        public List<Models.Entity.Type> Types { get; set; } //= new List<Models.Entity.Type>();

        public List<Year> Years { get; set; } //= new List<Year>();

        public LibraryContext (int T)
            {
                Books = new List<Book> ();
                Authors = new List<Author> ();
                Countries = new List<Country> ();
                Fields = new List<Field> ();
                Genres = new List<Genre> ();
                Languages = new List<Language> ();
                Tags = new List<Tag> ();
                Types = new List<Models.Entity.Type> ();
                Years = new List<Year> ();
                

            }


    }
}
