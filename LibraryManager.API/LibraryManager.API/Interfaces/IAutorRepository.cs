using LibraryManager.API.Entities;

namespace LibraryManager.API.Interfaces;

public interface IAutorRepository
{
    Task<IEnumerable<Autor>> GetAllAsync();

    Task<Autor?> GetByIdAsync(int id);

    Task AddAsync(Autor autor);

    Task UpdateAsync(Autor autor);

    Task DeleteAsync(int id);
}