using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Infrastructure.Configurations
{
    public class BebidaConfiguration : IEntityTypeConfiguration<Bebida>
    {
        public void Configure(EntityTypeBuilder<Bebida> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(w => w.Valor).HasPrecision(12, 2).IsRequired();
            builder.Property(w => w.Quantidade).HasMaxLength(100).IsRequired();
            builder.Property(w => w.UrlImagem).HasMaxLength(500);

            builder.HasOne(w => w.CategoriaBebida).WithMany(w => w.Bebidas).HasForeignKey(w => w.CategoriaBebidaId);
            builder.HasOne(w => w.Cardapio).WithMany(w => w.Bebidas).HasForeignKey(w => w.CardapioId);
        }
    }
}