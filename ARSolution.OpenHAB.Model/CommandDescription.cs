using System.Text.Json.Serialization;

namespace ARSolution.OpenHAB.Model
{
    public class CommandDescription
    {
        [JsonPropertyName("commandOptions")]
        public CommandOptions[] CommandOptions { get; set; }
    }
}