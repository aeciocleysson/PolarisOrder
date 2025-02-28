using PolarisOrder.Domain.Models;

namespace PolarisOrder.Application.Services.Interfaces
{
    public interface ITaxaServicoService
    {
        Task<TaxaServico> SavaAsync(TaxaServico taxaServico);
    }
}