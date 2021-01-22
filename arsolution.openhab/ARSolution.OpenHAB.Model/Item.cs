using System.Text.Json.Serialization;

namespace ARSolution.OpenHAB.Model
{
    public class Item
    {
        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("stateDescription")]
        public StateDescription StateDescription { get; set; }

        [JsonPropertyName("commandDescription")]
        public CommandDescription CommandDescription { get; set; }

        [JsonPropertyName("editable")]
        public bool IsEditable { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }

        [JsonPropertyName("groupNames")]
        public string[] GroupNames { get; set; }
    }
}