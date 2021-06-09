using Boilerplate.Core.Bases;
using Boilerplate.Core.Interfaces;
using Boilerplate.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Boilerplate.Infra.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<TEntity> Table;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Table = _dbContext.Set<TEntity>();
        }
        public async Task CreateAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            Table.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = Table.FindAsync(id);
            await DeleteAsync(entity.Result);
        }

        public async Task DeleteRangeAsync()
        {
            Table.RemoveRange(await Table.ToListAsync());
        }

        public async Task<IEnumerable<TEntity>> FilterAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FilterAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<EntityList<TEntity>> FilterPaginateAsync(int pageNumber, int pageRange)
        {
            var result = await Table.Skip(pageRange * (pageNumber - 1)).Take(pageRange).ToListAsync();

            return new EntityList<TEntity>(Table.Count(), result);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            Table.Update(entity);
            await SaveChangesAsync();
        }
    }
}
