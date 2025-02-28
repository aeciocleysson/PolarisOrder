using PolarisOrder.Domain.Interfaces;
using PolarisOrder.Domain.Models;
using PolarisOrder.Infrastructure.Context;

namespace PolarisOrder.Infrastructure.Repository
{
    public class TaxaServicoRepository : BaseRepository<TaxaServico>, ITaxaServicoRepository
    {
        private readonly PolarisOrderDbContext _context;

        public TaxaServicoRepository(PolarisOrderDbContext context) : base(context)
        {
            _context = context;
        }
    }
}