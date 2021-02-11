using System.Text.Json.Serialization;

namespace Project1
{
    public class Repository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
