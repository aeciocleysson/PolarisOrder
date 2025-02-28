using PolarisOrder.Domain.Models;

namespace PolarisOrder.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<T> SaveAsync(T model);

        T GetByIdAsync(int id);

        List<T> GetallAsync();

        Task<T> UpdateAsync(T model);

        bool DeleteAsync(int id);
    }
}