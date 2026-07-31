using System.Net.Http.Json;
using LibraryManager.API.DTOs;
using LibraryManager.API.DTOs.OpenLibrary;
using LibraryManager.API.Interfaces;

namespace LibraryManager.API.Services
{
    // Serviço que interage com a API Open Library para buscar informações de livros.
    public class OpenLibraryService : IOpenLibraryService
    {
        private readonly HttpClient _httpClient;

        public OpenLibraryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LivroOpenLibraryResponse?> BuscarLivroPorIsbnAsync(string isbn)
        {
            var url = $"search.json?isbn={isbn}";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var resultado =
                await response.Content.ReadFromJsonAsync<OpenLibrarySearchResponse>();

            if (resultado == null || resultado.Docs.Count == 0)
                return null;

            var livroEncontrado = resultado.Docs.First();

            return new LivroOpenLibraryResponse
            {
                Titulo = livroEncontrado.Title ?? string.Empty,

                Autor = livroEncontrado.AuthorName?.FirstOrDefault()
                        ?? "Autor desconhecido",

                ISBN = isbn,

                AnoPublicacao = livroEncontrado.FirstPublishYear,

                CapaUrl = livroEncontrado.CoverId.HasValue
                    ? $"https://covers.openlibrary.org/b/id/{livroEncontrado.CoverId}-L.jpg"
                    : null
            };
        }
    }
}