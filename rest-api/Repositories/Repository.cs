using Microsoft.EntityFrameworkCore;
using rest_api.Interfaces;
using rest_api.Models;

namespace rest_api.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly EcommerceDBContext _context;
        internal DbSet<TEntity> dbSet;
        public Repository(EcommerceDBContext context)
        {
            _context = context;
            dbSet = context.Set<TEntity>();
        }
        
        public async Task<List<TEntity>> GetListAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task InsertAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
