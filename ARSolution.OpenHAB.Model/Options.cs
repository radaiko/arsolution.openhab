using System.Text.Json.Serialization;

namespace ARSolution.OpenHAB.Model
{
    public class Options
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}