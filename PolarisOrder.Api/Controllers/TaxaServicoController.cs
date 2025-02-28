using Microsoft.AspNetCore.Mvc;
using PolarisOrder.Application.Services.Interfaces;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaServicoController : ControllerBase
    {
        private readonly ITaxaServicoService _taxaServicoService;

        public TaxaServicoController(ITaxaServicoService taxaServicoService)
        {
            _taxaServicoService = taxaServicoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TaxaServico taxaServico)
        {
            return Ok(await _taxaServicoService.SavaAsync(taxaServico));
        }
    }
}
