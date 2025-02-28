using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Infrastructure.Configurations
{
    public class TaxaServicoConfiguration : IEntityTypeConfiguration<TaxaServico>
    {
        public void Configure(EntityTypeBuilder<TaxaServico> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Nome).HasMaxLength(100).IsRequired();
            builder.Property(w => w.Valor).HasPrecision(12, 0).IsRequired();
        }
    }
}