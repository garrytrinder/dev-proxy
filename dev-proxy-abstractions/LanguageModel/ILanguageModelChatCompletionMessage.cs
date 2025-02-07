// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Abstractions.LanguageModel;

public interface ILanguageModelChatCompletionMessage
{
    string Content { get; set; }
    string Role { get; set; }
}