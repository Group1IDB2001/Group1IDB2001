using Project_3.Controllers;
using Project_3.Models.Entity;

namespace Project_3.DAL
{
    public class LibraryContext
    {
        public List<Author> Authors { get; set; }
        public List<AuthorCountry> AuthorCountries { get; set; }
        public List<Collection> Collections { get; set; }
        public List<CollectionItem> CollectionItems { get; set; }
        public List<Country> Countries { get; set; }
        public List<Item> Items { get; set; }
        public List<ItemAuthor> ItemAuthors { get; set; }
        public List<ItemLanguage> ItemLanguages { get; set; }
        public List<Language> Languages { get; set; }
        public List<Like> Likes { get; set; }
        public List<Qestion> Qestiones { get; set; }
        public List<Reaction> Reactions { get; set; }
        public List<ReactionEntity> ReactionEntities { get; set; }
        public List<Source> Sources { get; set; }
        public List<Tag> Tags { get; set; }
        public List<TagEntity> TagEntities { get; set; }
        public List<User> Users { get; set; }

        public LibraryContext ()
        {
            Authors = new List<Author> ();
            Authors.Add(new Author("Антон Павлович Чехов", 1860, 0, 1904));
            Authors.Add(new Author("Лев Николаевич Толстой", 1828, 0, 1910));
            Authors.Add(new Author("Джоан Роулинг", 1965, 1, 2022));
            Authors.Add(new Author("Терри Пратчетт", 1948, 0, 2015));
            Languages = new List<Language> ();

        }
        Guid GetAuthorByName (string Name)
        {
            
            return Guid.NewGuid ();
        }

    }
}
