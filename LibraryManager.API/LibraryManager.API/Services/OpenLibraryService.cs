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
        // Implementação do método BuscarLivroPorIsbnAsync
        public async Task<string?> BuscarLivroPorIsbnAsync(string isbn)
        {
            var url = $"isbn/{isbn}.json";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsStringAsync();
        }
    }
}