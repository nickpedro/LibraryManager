using LibraryManager.API.DTOs;
using LibraryManager.API.Entities;
using LibraryManager.API.Interfaces;

namespace LibraryManager.API.Services;

public class AutorService : IAutorService
{
    private readonly IAutorRepository _repository;

    public AutorService(IAutorRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<AutorResponse>> GetAllAsync()
    {
        var autores = await _repository.GetAllAsync();

        return autores.Select(a => new AutorResponse
        {
            Id = a.Id,
            Nome = a.Nome,
            Nacionalidade = a.Nacionalidade,
            DataNascimento = a.DataNascimento
        });
    }

    public async Task<AutorResponse?> GetByIdAsync(int id)
    {
        var autor = await _repository.GetByIdAsync(id);

        if (autor == null)
            return null;

        return new AutorResponse
        {
            Id = autor.Id,
            Nome = autor.Nome,
            Nacionalidade = autor.Nacionalidade,
            DataNascimento = autor.DataNascimento
        };
    }

    public async Task AddAsync(AutorRequest request)
    {
        var autor = new Autor
        {
            Nome = request.Nome,
            Nacionalidade = request.Nacionalidade,
            DataNascimento = request.DataNascimento
        };

        await _repository.AddAsync(autor);
    }

    public async Task UpdateAsync(int id, AutorRequest request)
    {
        var autor = await _repository.GetByIdAsync(id);

        if (autor == null)
            throw new Exception("Autor não encontrado.");

        autor.Nome = request.Nome;
        autor.Nacionalidade = request.Nacionalidade;
        autor.DataNascimento = request.DataNascimento;

        await _repository.UpdateAsync(autor);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}