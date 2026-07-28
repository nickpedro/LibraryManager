using System.Text.Json.Serialization;

namespace LibraryManager.API.DTOs.OpenLibrary
{
    public class OpenLibrarySearchDocument
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("author_name")]
        public List<string>? AuthorName { get; set; }

        [JsonPropertyName("first_publish_year")]
        public int? FirstPublishYear { get; set; }

        [JsonPropertyName("cover_i")]
        public int? CoverId { get; set; }

        [JsonPropertyName("isbn")]
        public List<string>? Isbn { get; set; }
    }
}