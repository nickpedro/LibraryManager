using LibraryManager.API.DTOs;

namespace LibraryManager.API.Interfaces;

public interface IAutorService
{
    Task<IEnumerable<AutorResponse>> GetAllAsync();

    Task<AutorResponse?> GetByIdAsync(int id);

    Task AddAsync(AutorRequest request);

    Task UpdateAsync(int id, AutorRequest request);

    Task DeleteAsync(int id);
}