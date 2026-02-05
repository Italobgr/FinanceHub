
using FinanceHub.Domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceHub.Infrastucture.Data.Mappings
{

  public class ContaMapping : IEntityTypeConfiguration<Conta> 
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            
        }

    }

}