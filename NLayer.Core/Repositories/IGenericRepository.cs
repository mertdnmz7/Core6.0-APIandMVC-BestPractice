using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T>where T : class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression); 

        // propductRepository.where(x=>x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        // Birden fazla eklemek için.
        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);

        // Birden fazla silmek için.
        void RemoveRange(IEnumerable<T> entities);
        
    }
}
