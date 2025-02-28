using PolarisOrder.Domain.Interfaces;
using PolarisOrder.Domain.Models;
using PolarisOrder.Infrastructure.Context;

namespace PolarisOrder.Infrastructure.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly PolarisOrderDbContext _context;

        protected BaseRepository(PolarisOrderDbContext context)
        {
            _context = context;
        }

        public bool DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetallAsync()
        {
            throw new NotImplementedException();
        }

        public T GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> SaveAsync(T model)
        {
            await _context.Set<T>().AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public Task<T> UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}