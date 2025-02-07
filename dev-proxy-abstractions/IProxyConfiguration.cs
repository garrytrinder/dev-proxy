// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using Microsoft.Extensions.Logging;

namespace Microsoft.DevProxy.Abstractions;

public interface IProxyConfiguration
{
    int ApiPort { get; }
    bool AsSystemProxy { get; }
    string? IPAddress { get; }
    string ConfigFile { get; }
    bool InstallCert { get; }
    MockRequestHeader[]? FilterByHeaders { get; }
    LogLevel LogLevel { get; }
    bool NoFirstRun { get; }
    int Port { get; }
    int Rate { get; }
    bool Record { get; }
    IEnumerable<int> WatchPids { get; }
    IEnumerable<string> WatchProcessNames { get; }
    bool ShowTimestamps { get; }
}