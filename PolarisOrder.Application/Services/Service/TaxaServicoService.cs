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

        public Task<bool> DeleteAsync(int id)
        {
            return _taxaServicoRepository.DeleteAsync(id);
        }

        public async Task<List<TaxaServico>> GetAllAsync()
        {
            return await _taxaServicoRepository.GetAllAsync();
        }

        public async Task<TaxaServico> GetByIdAsync(int id)
        {
            if (id > 0)
                return await _taxaServicoRepository.GetByIdAsync(id);

            return null;
        }

        public async Task<TaxaServico> SavaAsync(TaxaServico taxaServico)
        {
            return await _taxaServicoRepository.SaveAsync(taxaServico);
        }

        public async Task<TaxaServico> UpdateAsync(TaxaServico model)
        {
            return await _taxaServicoRepository.UpdateAsync(model);
        }
    }
}