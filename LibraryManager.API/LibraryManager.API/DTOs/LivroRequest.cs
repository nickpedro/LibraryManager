namespace LibraryManager.API.DTOs
{
    public class LivroRequest
    {
        public string Titulo { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int? AnoPublicacao { get; set; }

        public int QuantidadeTotal { get; set; }
    }
}