using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Infrastructure.Configurations
{
    public class MesaConfiguration : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Nome).HasMaxLength(100).IsRequired();
            builder.Property(w => w.QrCode).HasMaxLength(500).IsRequired();
        }
    }
}