using System.Text.Json.Serialization;

namespace LibraryManager.API.DTOs.OpenLibrary
{
    public class OpenLibrarySearchResponse
    {
        [JsonPropertyName("docs")]
        public List<OpenLibrarySearchDocument> Docs { get; set; } = new();
    }
}