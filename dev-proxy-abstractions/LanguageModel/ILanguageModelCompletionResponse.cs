// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Abstractions.LanguageModel;

public interface ILanguageModelCompletionResponse
{
    string? Error { get; set; }
    string? Response { get; set; }
}