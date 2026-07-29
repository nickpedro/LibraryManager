using LibraryManager.API.DTOs;

namespace LibraryManager.API.Interfaces
{
    public interface IOpenLibraryService
    {
        Task<LivroOpenLibraryResponse?> BuscarLivroPorIsbnAsync(string isbn);
    }
}