using Kontas.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        private DbContext dbContext;
        private readonly DbSet<T> dbSet;
        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }
        public IEnumerable<T> Get()
        {
            return dbSet;
        }
        public T Get(int id)
        {
            return dbSet.Find(id);
        }
        public void Update(T entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = dbSet.Find(id);
            if (entity == null)
            {
                return;
            }
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }
    }
}
