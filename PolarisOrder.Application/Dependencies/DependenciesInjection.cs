using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PolarisOrder.Application.Services.Interfaces;
using PolarisOrder.Application.Services.Service;
using PolarisOrder.Domain.Interfaces;
using PolarisOrder.Infrastructure.Repository;

namespace PolarisOrder.Application.Dependencies
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection service, IConfiguration configuration)
        {
            //service.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            service.AddScoped<ITaxaServicoRepository, TaxaServicoRepository>();
            service.AddScoped<ITaxaServicoService, TaxaServicoService>();

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            return service;
        }
    }
}