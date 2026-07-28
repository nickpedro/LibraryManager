using LibraryManager.API.DTOs.OpenLibrary;

namespace LibraryManager.API.Interfaces
{
    public interface IOpenLibraryService
    {
        Task<OpenLibrarySearchDocument?> BuscarLivroPorIsbnAsync(string isbn);
    }
}