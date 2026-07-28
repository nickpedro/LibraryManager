using System.Text.Json.Serialization;

namespace LibraryManager.API.DTOs.OpenLibrary
{
    public class OpenLibraryAuthorReference
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }
    }
}