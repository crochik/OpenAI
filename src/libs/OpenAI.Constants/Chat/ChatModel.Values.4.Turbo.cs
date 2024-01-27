// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

/// <summary>
/// According:
/// - https://platform.openai.com/docs/models/
/// - https://openai.com/blog/new-embedding-models-and-api-updates
/// - https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo
/// <remarks>
/// OpenAI models are non-deterministic, meaning that identical inputs can yield different outputs.
/// Setting temperature to 0 will make the outputs mostly deterministic, but a small amount of variability may remain.
/// </remarks>
/// </summary>
public readonly partial record struct ChatModel
{
    /// <summary>
    /// The GPT-4 model with improved instruction following, JSON mode, reproducible outputs,
    /// parallel function calling, and more.
    /// This preview model is not yet suited for production traffic. <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_1106_PreviewValue = "gpt-4-1106-preview";
    
    /// <summary>
    /// Today, we are releasing an updated GPT-4 Turbo preview model, gpt-4-0125-preview.
    /// This model completes tasks like code generation more thoroughly than the previous preview model
    /// and is intended to reduce cases of “laziness” where the model doesn’t complete a task.
    /// The new model also includes the fix for the bug impacting non-English UTF-8 generations. <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_0125_PreviewValue = "gpt-4-0125-preview";

    /// <inheritdoc cref="Gpt4_0125_PreviewValue"/>
    /// <remarks>Alias - Currently points to gpt-4-0125-preview.</remarks>
    internal const string Gpt4TurboPreviewValue = "gpt-4-turbo-preview";
    
    /// <inheritdoc cref="Gpt4_1106_PreviewValue"/>
    public static ChatModel Gpt4_1106_Preview { get; } = new(Gpt4_1106_PreviewValue);
    
    /// <inheritdoc cref="Gpt4_0125_PreviewValue"/>
    public static ChatModel Gpt4_0125_Preview { get; } = new(Gpt4_0125_PreviewValue);
    
    /// <inheritdoc cref="Gpt4TurboPreviewValue"/>
    public static ChatModel Gpt4TurboPreview { get; } = new(Gpt4TurboPreviewValue);
}