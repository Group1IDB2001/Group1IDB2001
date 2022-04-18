using Project_3.DAL;
using Project_3.Models.Entity;
using System.Linq;

namespace Project_3.Managers.Books
{
    public class BookManager<T>:IBookManager<T> where T : class
    {
        //private LibraContext _context;
        //private DbSet<T> table =null;

        //public BookManager(LibraContext context)
        //{
        //    _context = context;
        //    table = _context.set<T>();
        //}

        public void Delete(object id)
        {
            throw new NotImplementedException();

            // T existing =GetById (id)
            // table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
            //return table.ToList();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
            //return table.Find(id);
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
            //table.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
            //table.Attach(entity);
            //_context.Entry(entity).State = EntityState.Modified;
        }
    }
}
