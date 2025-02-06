using System.Text.Json.Serialization;

namespace BlazorApp.Model.Files
{
    public class CopyOrMoveFile()
    {
        [JsonPropertyName("filePathOrigin")]
        public string FilePathOrigin { get; set; } = string.Empty;
        [JsonPropertyName("filePathDestination")]
        public string FilePathDestination { get; set; } = string.Empty;
        [JsonPropertyName("createDestinationDirectoryIfNotExists")]
        public bool CreateDestinationDirectoryIfNotExists { get; set; }
    }
}
