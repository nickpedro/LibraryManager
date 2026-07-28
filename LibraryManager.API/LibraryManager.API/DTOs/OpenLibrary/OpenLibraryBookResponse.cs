using System.Text.Json.Serialization;

namespace LibraryManager.API.DTOs.OpenLibrary
{
    // DTO para representar a resposta da API Open Library
    public class OpenLibraryBookResponse
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        [JsonPropertyName("publish_date")]
        public string? PublishDate { get; set; }

        [JsonPropertyName("covers")]
        public List<int>? Covers { get; set; }

        [JsonPropertyName("authors")]
        public List<OpenLibraryAuthorReference>? Authors { get; set; }
    }
}