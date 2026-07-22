using LibraryManager.API.Entities;

namespace LibraryManager.API.Interfaces
{
    // Interface para o repositório de livros, definindo os métodos que serão implementados na classe LivroRepository.
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> GetAllAsync();

        Task<Livro?> GetByIdAsync(int id);

        Task AddAsync(Livro livro);

        Task UpdateAsync(Livro livro);

        Task DeleteAsync(int id);
    }
}