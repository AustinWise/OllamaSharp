using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using OllamaSharp.Models;
using OllamaSharp.Models.Chat;

namespace OllamaSharp;

[JsonSourceGenerationOptions]
[JsonSerializable(typeof(ChatDoneResponseStream))]
[JsonSerializable(typeof(ChatRequest))]
[JsonSerializable(typeof(ChatResponseStream))]
[JsonSerializable(typeof(CopyModelRequest))]
[JsonSerializable(typeof(CreateModelRequest))]
[JsonSerializable(typeof(CreateModelResponse))]
[JsonSerializable(typeof(DeleteModelRequest))]
[JsonSerializable(typeof(EmbedRequest))]
[JsonSerializable(typeof(EmbedResponse))]
[JsonSerializable(typeof(ErrorResponse))]
[JsonSerializable(typeof(GenerateDoneResponseStream))]
[JsonSerializable(typeof(GenerateRequest))]
[JsonSerializable(typeof(GenerateResponseStream))]
[JsonSerializable(typeof(GenerateResponseStream))]
[JsonSerializable(typeof(ListModelsResponse))]
[JsonSerializable(typeof(ListRunningModelsResponse))]
[JsonSerializable(typeof(Message.Function), TypeInfoPropertyName = "MessageFunction")] // Disambiguate with OllamaSharp.Models.Chat.Function
[JsonSerializable(typeof(Parameters))]
[JsonSerializable(typeof(PullModelRequest))]
[JsonSerializable(typeof(PullModelResponse))]
[JsonSerializable(typeof(PushModelRequest))]
[JsonSerializable(typeof(PushModelResponse))]
[JsonSerializable(typeof(ShowModelRequest))]
[JsonSerializable(typeof(ShowModelResponse))]
[JsonSerializable(typeof(VersionResponse))]
[JsonSerializable(typeof(JsonNode))] // TODO: remove when test GenerateSword_ShouldSucceed no longer needs it.
[JsonSerializable(typeof(double))] // TODO: remove when test CreateModel no longer needs it.
internal partial class SourceGenerationContext : JsonSerializerContext
{
}
