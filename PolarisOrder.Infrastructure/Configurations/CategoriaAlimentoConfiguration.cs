using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Infrastructure.Configurations
{
    public class CategoriaAlimentoConfiguration : IEntityTypeConfiguration<CategoriaAlimento>
    {
        public void Configure(EntityTypeBuilder<CategoriaAlimento> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Nome).HasMaxLength(100).IsRequired();
        }
    }
}