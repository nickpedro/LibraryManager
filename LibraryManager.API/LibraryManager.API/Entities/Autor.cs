namespace LibraryManager.API.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public List<Livro> Livros { get; set; } = new(); //Um autor pode ter vários livros
    }
}
