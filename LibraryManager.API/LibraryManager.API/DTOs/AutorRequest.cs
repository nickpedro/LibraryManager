namespace LibraryManager.API.DTOs
{
    public class AutorRequest
    {
        public string Nome { get; set; } = string.Empty;

        public string? Nacionalidade { get; set; }

        public DateTime? DataNascimento { get; set; }
    }
}
