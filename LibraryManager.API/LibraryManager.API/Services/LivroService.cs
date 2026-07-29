using LibraryManager.API.DTOs;
using LibraryManager.API.Entities;
using LibraryManager.API.Interfaces;

namespace LibraryManager.API.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;
        private readonly IOpenLibraryService _openLibraryService;

        public LivroService(
            ILivroRepository repository,
            IOpenLibraryService openLibraryService)
        {
            _repository = repository;
            _openLibraryService = openLibraryService;
        }

        // Recupera todos os livros do repositório
        // e os transforma em objetos de resposta.
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

        // Busca um livro pelo ID.
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

        // Adiciona um livro manualmente.
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

        // Busca os dados do livro na Open Library pelo ISBN
        // e cadastra o livro no nosso banco.
        public async Task<LivroResponse> AddByIsbnAsync(LivroIsbnRequest request)
        {
            var livroOpenLibrary =
                await _openLibraryService.BuscarLivroPorIsbnAsync(request.ISBN);

            if (livroOpenLibrary == null)
                throw new Exception("Livro não encontrado na Open Library.");

            var livro = new Livro
            {
                Titulo = livroOpenLibrary.Titulo,
                ISBN = request.ISBN,
                AnoPublicacao = livroOpenLibrary.AnoPublicacao,
                CapaUrl = livroOpenLibrary.CapaUrl,
                QuantidadeTotal = request.Quantidade,
                QuantidadeDisponivel = request.Quantidade
            };

            await _repository.AddAsync(livro);

            return new LivroResponse
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                ISBN = livro.ISBN,
                AnoPublicacao = livro.AnoPublicacao,
                QuantidadeDisponivel = livro.QuantidadeDisponivel
            };
        }

        // Atualiza um livro existente.
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

        // Exclui um livro.
        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}