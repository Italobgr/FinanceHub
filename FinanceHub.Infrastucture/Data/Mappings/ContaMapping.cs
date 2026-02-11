
using FinanceHub.Domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceHub.Infrastucture.Data.Mappings
{

  public class ContaMapping : IEntityTypeConfiguration<Conta> 
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("contas");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100).HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Saldo).IsRequired().HasColumnType("DECIMAL(18.2)");//18 digitos no total sendo  duas casas decimais

            builder.Property(c => c.Ativa).IsRequired();

        }

    }

}