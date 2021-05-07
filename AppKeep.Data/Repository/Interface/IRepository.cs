using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> GetAsync(int id);

        IQueryable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> Delete(TEntity entity);

        void Update(TEntity obj);

        int SaveChanges();
    }
}