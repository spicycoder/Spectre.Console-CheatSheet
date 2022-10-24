using System.Text.Json.Serialization;

namespace SpectreCheatSheet
{
    public class Response
    {
        [JsonPropertyName("data")]
        public User User { get; set; }
    }
}
