using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PolarisOrder.Domain.Models;

namespace PolarisOrder.Infrastructure.Configurations
{
    public class AlimentoConfiguration : IEntityTypeConfiguration<Alimento>
    {
        public void Configure(EntityTypeBuilder<Alimento> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(w => w.Valor).HasPrecision(12, 2).IsRequired();
            builder.Property(w => w.Quantidade).HasMaxLength(100).IsRequired();
            builder.Property(w => w.UrlImagem).HasMaxLength(500);

            builder.HasOne(w => w.CategoriaAlimento).WithMany(w => w.Alimentos).HasForeignKey(w => w.CategoriaAlimentoId);
            builder.HasOne(w => w.Cardapio).WithMany(w => w.Alimentos).HasForeignKey(w => w.CardapioId);
        }
    }
}