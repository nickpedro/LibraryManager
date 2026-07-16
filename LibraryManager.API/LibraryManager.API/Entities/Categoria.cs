namespace LibraryManager.API.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public List<Livro> Livros { get; set; } = new(); //Pode existir diversas categorias para um livro, mas um livro pertence a uma categoria
    }
}
