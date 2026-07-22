namespace LibraryManager.API.Entities
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int? AnoPublicacao { get; set; }

        public string? CapaUrl { get; set; }

        public int QuantidadeTotal { get; set; }

        public int QuantidadeDisponivel { get; set; }

        // Chaves estrangeiras
        public int? AutorId { get; set; }

        public int? CategoriaId { get; set; }

        // Navegação
        public Autor? Autor { get; set; }

        public Categoria? Categoria { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
    }
}