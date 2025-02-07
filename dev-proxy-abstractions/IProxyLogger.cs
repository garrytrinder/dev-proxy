// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using Titanium.Web.Proxy.EventArguments;

namespace Microsoft.DevProxy.Abstractions;

public enum MessageType
{
    Normal,
    InterceptedRequest,
    PassedThrough,
    Warning,
    Tip,
    Failed,
    Chaos,
    Mocked,
    InterceptedResponse,
    FinishedProcessingRequest,
    Skipped,
    Processed,
    Timestamp
}

public class LoggingContext(SessionEventArgs session)
{
    public SessionEventArgs Session { get; } = session;
}