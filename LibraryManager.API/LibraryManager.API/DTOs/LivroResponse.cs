namespace LibraryManager.API.DTOs
{
    public class LivroResponse
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int? AnoPublicacao { get; set; }

        public int QuantidadeDisponivel { get; set; }
    }
}