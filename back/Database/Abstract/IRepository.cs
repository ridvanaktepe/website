namespace back.Database.Abstract
{
    public interface IRepository<T>
    {
        Task<T?> GetById(string id);
        Task<List<T>> GetAll();
        Task Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}