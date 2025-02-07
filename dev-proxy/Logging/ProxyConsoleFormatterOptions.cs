// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using Microsoft.Extensions.Logging.Console;

namespace Microsoft.DevProxy.Logging;

public class ProxyConsoleFormatterOptions: ConsoleFormatterOptions
{
    public bool ShowSkipMessages { get; set; } = true;

    public bool ShowTimestamps { get; set; } = true;
}