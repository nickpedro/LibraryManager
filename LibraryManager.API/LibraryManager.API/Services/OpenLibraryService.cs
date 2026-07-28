using System.Net.Http.Json;
using LibraryManager.API.DTOs.OpenLibrary;
using LibraryManager.API.Interfaces;

namespace LibraryManager.API.Services
{
    public class OpenLibraryService : IOpenLibraryService
    {
        private readonly HttpClient _httpClient;

        public OpenLibraryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<OpenLibrarySearchDocument?> BuscarLivroPorIsbnAsync(string isbn)
        {
            var url = $"search.json?isbn={isbn}";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var resultado =
                await response.Content.ReadFromJsonAsync<OpenLibrarySearchResponse>();

            if (resultado == null || resultado.Docs.Count == 0)
                return null;

            return resultado.Docs.FirstOrDefault();
        }
    }
}