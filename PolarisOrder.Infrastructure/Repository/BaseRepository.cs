using Microsoft.EntityFrameworkCore;
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

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            model.Delete();

            _context.ChangeTracker.Clear();

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return true;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task<T> SaveAsync(T model)
        {
            await _context.Set<T>().AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public virtual async Task<T> UpdateAsync(T model)
        {
            _context.ChangeTracker.Clear();

            model.Atualizacao = DateTime.Now;

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return model;
        }
    }
}