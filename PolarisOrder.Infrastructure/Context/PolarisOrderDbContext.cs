using Microsoft.EntityFrameworkCore;
using PolarisOrder.Domain.Models;
using System.Reflection;

namespace PolarisOrder.Infrastructure.Context
{
    public class PolarisOrderDbContext : DbContext
    {
        public PolarisOrderDbContext(DbContextOptions<PolarisOrderDbContext> options) : base(options)
        {
        }

        public DbSet<Alimento> Alimento { get; set; }
        public DbSet<Bebida> Bebida { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<CategoriaAlimento> CategoriaAlimento { get; set; }
        public DbSet<CategoriaBebida> CategoriaBebida { get; set; }
        public DbSet<Mesa> Mesa { get; set; }
        public DbSet<TaxaServico> TaxaServico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}