// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using Microsoft.DevProxy.Abstractions;

namespace Microsoft.DevProxy;

public interface IProxyState
{
    Dictionary<string, object> GlobalData { get; }
    bool IsRecording { get; }
    IProxyConfiguration ProxyConfiguration { get; }
    List<RequestLog> RequestLogs { get; }
    Task RaiseMockRequestAsync();
    void StartRecording();
    void StopProxy();
    Task StopRecordingAsync();
}