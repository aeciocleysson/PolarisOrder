using PolarisOrder.Application.Services.Interfaces;
using PolarisOrder.Domain.Interfaces;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Application.Services.Service
{
    public class TaxaServicoService : ITaxaServicoService
    {
        private readonly ITaxaServicoRepository _taxaServicoRepository;

        public TaxaServicoService(ITaxaServicoRepository taxaServicoRepository)
        {
            _taxaServicoRepository = taxaServicoRepository;
        }

        public async Task<TaxaServico> SavaAsync(TaxaServico taxaServico)
        {
            return await _taxaServicoRepository.SaveAsync(taxaServico);
        }
    }
}