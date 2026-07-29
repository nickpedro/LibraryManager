namespace LibraryManager.API.DTOs
{
    // DTO representa a resposta da API Open Library para um livro específico.
    public class LivroOpenLibraryResponse
    {
        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int? AnoPublicacao { get; set; }

        public string? CapaUrl { get; set; }
    }
}