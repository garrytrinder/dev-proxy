// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.DevProxy.Plugins;

public class GraphErrorResponseBody(GraphErrorResponseError error)
{
    public GraphErrorResponseError Error { get; set; } = error;
}

public class GraphErrorResponseError
{
    public string Code { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public GraphErrorResponseInnerError? InnerError { get; set; }
}

public class GraphErrorResponseInnerError
{
    [JsonPropertyName("request-id")]
    public string RequestId { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
}
