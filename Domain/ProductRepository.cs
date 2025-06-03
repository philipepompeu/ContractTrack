using ContractTrack.Data;
using ContractTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContractTrack.Domain
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Product> _dbSet;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Product>();
        }
        public async Task AddAsync(Product entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
