// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.ApiControllers;

public class ProxyInfo
{
    public bool? Recording { get; set; }
    public string? ConfigFile { get; init; }

    public static ProxyInfo From(IProxyState proxyState)
    {
        return new ProxyInfo
        {
            ConfigFile = proxyState.ProxyConfiguration.ConfigFile,
            Recording = proxyState.IsRecording
        };
    }
}
