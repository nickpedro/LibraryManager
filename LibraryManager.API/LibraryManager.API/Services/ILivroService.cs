using LibraryManager.API.DTOs;

namespace LibraryManager.API.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<LivroResponse>> GetAllAsync();

        Task<LivroResponse?> GetByIdAsync(int id);

        Task AddAsync(LivroRequest request);

        Task UpdateAsync(int id, LivroRequest request);

        Task DeleteAsync(int id);
    }
}