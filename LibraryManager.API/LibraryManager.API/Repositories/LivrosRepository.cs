using LibraryManager.API.Data;
using LibraryManager.API.Entities;
using LibraryManager.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.API.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LibraryDbContext _context;

        public LivroRepository(LibraryDbContext context)
        {
            _context = context;
        }
        // Serve para obter todos os livros do banco de dados, incluindo informações sobre o autor e a categoria de cada livro.
        public async Task<IEnumerable<Livro>> GetAllAsync()
        {
            return await _context.Livros
                .Include(l => l.Autor)
                .Include(l => l.Categoria)
                .ToListAsync();
        }

        public async Task<Livro?> GetByIdAsync(int id)
        {
            return await _context.Livros
                .Include(l => l.Autor)
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddAsync(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Livro livro)
        {
            _context.Livros.Update(livro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var livro = await _context.Livros.FindAsync(id);

            if (livro is null)
                return;

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }
    }
}