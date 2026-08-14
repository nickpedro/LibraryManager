namespace LibraryManager.API.DTOs;

public class AutorResponse
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? Nacionalidade { get; set; }

    public DateTime? DataNascimento { get; set; }
}