using ITLabTest.Repository.Interfaces;
using ITLabTest.SqlServer.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ITLabTest.SqlServer.EFCore.Repository
{
    public class SqlServerEfCore<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly EfCoreDbContext _dbContext;

        public SqlServerEfCore(EfCoreDbContext context)
        {
            this._dbContext = context;
        }

        public IEnumerable<TEntity> All()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task Delete(Guid id)
        {
            var entity = await ListById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public IEnumerable<TEntity> List(Expression<TEntity> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> ListById(Guid id)
        {
            throw new NotImplementedException();
            //return await _dbContext.Set<TEntity>()
            //    .AsNoTracking()
            //    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
