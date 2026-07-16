namespace LibraryManager.API.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string ISNB { get; set; } = string.Empty;
        public int? AnoPublicacao { get; set; }
        public string? CapaUrl { get; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeDisponivel { get; set; }
    }
}
