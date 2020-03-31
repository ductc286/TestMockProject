using System.Collections.Generic;
using System.Linq;

namespace TestMockProject.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Find(object id);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> FindAll();
        int Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        void Dispose();
    }
}
