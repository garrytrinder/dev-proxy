// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Abstractions.LanguageModel;

public interface ILanguageModelClient
{
    Task<ILanguageModelCompletionResponse?> GenerateChatCompletionAsync(ILanguageModelChatCompletionMessage[] messages);
    Task<ILanguageModelCompletionResponse?> GenerateCompletionAsync(string prompt);
    Task<bool> IsEnabledAsync();
}