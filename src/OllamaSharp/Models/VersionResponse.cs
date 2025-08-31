using System.Text.Json.Serialization;
using OllamaSharp.Constants;

namespace OllamaSharp.Models;
internal class VersionResponse
{
	[JsonPropertyName(Application.Version)]
	public string? Version { get; set; }
}
