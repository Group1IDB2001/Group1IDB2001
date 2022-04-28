namespace Project_3.Managers.Books
{
    public class UnitOfWorkManager<T> : IUnitOfWorkManager<T> where T : class
    {
        //private LibraContext _context;
        //private  IBookManager<T> _entity;
        //public UnitOfWorkManager(LibraContext context)
        //{
        //     _context = context;
        //}
        public IBookManager<T> Entity => throw new NotImplementedException();
        //public IBookManager<T> Entity =>{
        //get{
        //
        //   return _entity ?? (_entity = new BookManager<T>(_context)) ;
        //
        //}

        public void Save()
        {
            throw new NotImplementedException();
            //_context.SaveChanges();
        }
    }
}
