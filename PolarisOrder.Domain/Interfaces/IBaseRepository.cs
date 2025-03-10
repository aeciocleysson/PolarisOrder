using PolarisOrder.Domain.Models;

namespace PolarisOrder.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<T> SaveAsync(T model);

        Task<T?> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<T> UpdateAsync(T model);

        Task<bool> DeleteAsync(int id);
    }
}