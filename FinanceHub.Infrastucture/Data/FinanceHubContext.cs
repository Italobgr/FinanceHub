using FinanceHub.Domain.entities;
using FinanceHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceHub.Infrastucture
{
    public class FinanceHubContext : DbContext
    {

        public FinanceHubContext(DbContextOptions<FinanceHubContext> options) : base(options){}
        

            //tabelas 
            public DbSet<Conta> Contas { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Transacao> Transacoes { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinanceHubContext).Assembly);

                base.OnModelCreating(modelBuilder);

            }


    }
}