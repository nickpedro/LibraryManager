using LibraryManager.API.Data;
using LibraryManager.API.Entities;
using LibraryManager.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.API.Repositories;

public class AutorRepository : IAutorRepository
{
    private readonly LibraryDbContext _context;

    public AutorRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Autor>> GetAllAsync()
    {
        return await _context.Autores.ToListAsync();
    }

    public async Task<Autor?> GetByIdAsync(int id)
    {
        return await _context.Autores.FindAsync(id);
    }

    public async Task AddAsync(Autor autor)
    {
        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Autor autor)
    {
        _context.Autores.Update(autor);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var autor = await _context.Autores.FindAsync(id);

        if (autor == null)
            return;

        _context.Autores.Remove(autor);
        await _context.SaveChangesAsync();
    }
}