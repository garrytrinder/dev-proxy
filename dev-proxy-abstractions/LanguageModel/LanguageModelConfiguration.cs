// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Abstractions.LanguageModel;

public class LanguageModelConfiguration
{
    public bool Enabled { get; set; } = false;
    // default Ollama URL
    public string? Url { get; set; } = "http://localhost:11434";
    public string? Model { get; set; } = "phi3";
    public bool CacheResponses { get; set; } = true;
}