

using FinanceHub.Domain.entities;

namespace FinanceHub.Domain.Interfaces
{
    
 public interface ICategoriaRepository
    {
        
        Task<Categoria> CreateAsync(Categoria categoria);

        Task<IEnumerable<Categoria>> GetAllAsync(); //entender o fuuncionamento do IEnumerable

        Task<Categoria> GetByIdAsync();

    }

}