namespace LibraryManager.API.DTOs
{
    public class LivroIsbnRequest
    {
        public string ISBN { get; set; } = string.Empty;

        public int Quantidade { get; set; }
    }
}