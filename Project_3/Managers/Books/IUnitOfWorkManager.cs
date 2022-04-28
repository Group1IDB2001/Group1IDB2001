namespace Project_3.Managers.Books
{
    public interface IUnitOfWorkManager<T> where T : class
    {
        IBookManager<T> Entity { get; }//just save 
        void Save();
    }
}
