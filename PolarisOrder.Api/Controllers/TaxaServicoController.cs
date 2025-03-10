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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _taxaServicoService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            return Ok(await _taxaServicoService.GetByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleted(int id)
        {
            return Ok(await _taxaServicoService.DeleteAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TaxaServico taxaServico)
        {
            return Ok(await _taxaServicoService.UpdateAsync(taxaServico));
        }
    }
}