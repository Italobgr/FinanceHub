
using FinanceHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceHub.Infrastucture.Data.Mappings
{
public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {

            builder.ToTable("transacoes");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100).HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Valor).IsRequired().HasColumnType("DECIMAL(18,2)");//18 digitos no total sendo  duas casas decimais

            builder.Property(c => c.Data).IsRequired().HasColumnType("DATETIME");

            builder.Property(c => c.Tipo).IsRequired().HasMaxLength(100).HasConversion<int>();


            // NÃO definimos ColumnType para Guid. O EF Core faz isso sozinho no caso dos guris abaixo 
            // - FK
            builder.Property(c => c.ContaId).IsRequired();

            builder.Property(c => c.CategoriaId).IsRequired();


            //RELACIONAMENTOS

            builder.HasOne(c => c.Conta)
            .WithMany()
            .HasForeignKey(t => t.ContaId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Categoria)
            .WithMany()
            .HasForeignKey(t => t.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        }

    }

}