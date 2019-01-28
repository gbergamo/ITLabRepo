using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ITLabTest.Repository.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(Guid id);
        IEnumerable<TEntity> All();
        Task<TEntity> ListById(Guid id);
        IEnumerable<TEntity> List(Expression<TEntity> expression);
    }
}
