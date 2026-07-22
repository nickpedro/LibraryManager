using LibraryManager.API.DTOs;
using LibraryManager.API.Entities;
using LibraryManager.API.Interfaces;

namespace LibraryManager.API.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;

        public LivroService(ILivroRepository repository)
        {
            _repository = repository;
        }
        // Recupera todos os livros do repositório e os transforma em objetos de resposta.
        public async Task<IEnumerable<LivroResponse>> GetAllAsync()
        {
            var livros = await _repository.GetAllAsync();

            return livros.Select(l => new LivroResponse
            {
                Id = l.Id,
                Titulo = l.Titulo,
                ISBN = l.ISBN,
                AnoPublicacao = l.AnoPublicacao,
                QuantidadeDisponivel = l.QuantidadeDisponivel
            });
        }

        public async Task<LivroResponse?> GetByIdAsync(int id)
        {
            var livro = await _repository.GetByIdAsync(id);

            if (livro == null)
                return null;

            return new LivroResponse
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                ISBN = livro.ISBN,
                AnoPublicacao = livro.AnoPublicacao,
                QuantidadeDisponivel = livro.QuantidadeDisponivel
            };
        }

        // Adiciona um novo livro ao repositório com base nos dados fornecidos na requisição.
        public async Task AddAsync(LivroRequest request)
        {
            var livro = new Livro
            {
                Titulo = request.Titulo,
                ISBN = request.ISBN,
                AnoPublicacao = request.AnoPublicacao,
                QuantidadeTotal = request.QuantidadeTotal,
                QuantidadeDisponivel = request.QuantidadeTotal
            };

            await _repository.AddAsync(livro);
        }

        public async Task UpdateAsync(int id, LivroRequest request)
        {
            var livro = await _repository.GetByIdAsync(id);

            if (livro == null)
                throw new Exception("Livro não encontrado.");

            livro.Titulo = request.Titulo;
            livro.ISBN = request.ISBN;
            livro.AnoPublicacao = request.AnoPublicacao;
            livro.QuantidadeTotal = request.QuantidadeTotal;

            await _repository.UpdateAsync(livro);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}