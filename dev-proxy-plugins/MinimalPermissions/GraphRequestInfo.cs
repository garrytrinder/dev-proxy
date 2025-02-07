// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.


using System.Text.Json.Serialization;

namespace Microsoft.DevProxy.Plugins.MinimalPermissions;

public class GraphRequestInfo
{
    [JsonPropertyName("requestUrl")]
    public string Url { get; set; } = string.Empty;
    public string Method { get; set; } = string.Empty;
}