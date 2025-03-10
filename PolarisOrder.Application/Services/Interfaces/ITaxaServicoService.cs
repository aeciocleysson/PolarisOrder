using PolarisOrder.Domain.Models;

namespace PolarisOrder.Application.Services.Interfaces
{
    public interface ITaxaServicoService
    {
        Task<TaxaServico> SavaAsync(TaxaServico taxaServico);

        Task<List<TaxaServico>> GetAllAsync();

        Task<TaxaServico> GetByIdAsync(int id);

        Task<bool> DeleteAsync(int id);

        Task<TaxaServico> UpdateAsync(TaxaServico model);
    }
}