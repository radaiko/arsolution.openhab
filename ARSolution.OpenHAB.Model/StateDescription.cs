using System.Text.Json.Serialization;

namespace ARSolution.OpenHAB.Model
{
    public class StateDescription
    {
        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }

        [JsonPropertyName("readOnly")]
        public bool IsReadOnly { get; set; }

        [JsonPropertyName("options")]
        public Options[] Options { get; set; }

        [JsonPropertyName("minimum")]
        public int Minimum { get; set; }

        [JsonPropertyName("maximum")]
        public int Maximum { get; set; }

        [JsonPropertyName("step")]
        public float Step { get; set; }
    }
}