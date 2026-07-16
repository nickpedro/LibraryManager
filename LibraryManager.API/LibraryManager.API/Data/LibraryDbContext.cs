using LibraryManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.API.Data
{
    public class LibraryDbContext : DbContext
    {
       public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        // Define os Entities que serão mapeados para o banco de dados
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
