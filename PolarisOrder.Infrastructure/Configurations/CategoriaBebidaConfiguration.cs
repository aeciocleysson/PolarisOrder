using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Infrastructure.Configurations
{
    public class CategoriaBebidaConfiguration : IEntityTypeConfiguration<CategoriaBebida>
    {
        public void Configure(EntityTypeBuilder<CategoriaBebida> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Nome).HasMaxLength(100).IsRequired();
        }
    }
}