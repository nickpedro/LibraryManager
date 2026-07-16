namespace LibraryManager.API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public List<Emprestimo> Emprestimos { get; set; } = new(); //Um usuário pode ter vários empréstimos
    }
}
