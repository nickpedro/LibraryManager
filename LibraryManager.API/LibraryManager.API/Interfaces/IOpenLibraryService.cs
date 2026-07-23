namespace LibraryManager.API.Interfaces
{
    public interface IOpenLibraryService
    {
        Task<string?> BuscarLivroPorIsbnAsync(string isbn);
    }
}