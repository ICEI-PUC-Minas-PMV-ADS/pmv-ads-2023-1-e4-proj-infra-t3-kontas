namespace Kontas.API.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        void Add(T entity);
        void Delete(int id);
        IEnumerable<T> Get();
        T Get(int id);
        void Update(T entity);
    }
}