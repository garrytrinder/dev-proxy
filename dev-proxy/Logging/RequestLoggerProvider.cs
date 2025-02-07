// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Collections.Concurrent;
using Microsoft.DevProxy.Abstractions;

namespace Microsoft.DevProxy.Logging;

public class RequestLoggerProvider(PluginEvents pluginEvents) : ILoggerProvider
{
    private readonly PluginEvents _pluginEvents = pluginEvents;
    private readonly ConcurrentDictionary<string, RequestLogger> _loggers = new();

    public ILogger CreateLogger(string categoryName) =>
        _loggers.GetOrAdd(categoryName, name => new RequestLogger(_pluginEvents));


    public void Dispose() => _loggers.Clear();
}