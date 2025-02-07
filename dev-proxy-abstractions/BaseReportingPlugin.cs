// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Microsoft.DevProxy.Abstractions;

public abstract class BaseReportingPlugin(IPluginEvents pluginEvents, IProxyContext context, ILogger logger, ISet<UrlToWatch> urlsToWatch, IConfigurationSection? configSection = null) : BaseProxyPlugin(pluginEvents, context, logger, urlsToWatch, configSection)
{
    protected virtual void StoreReport(object report, ProxyEventArgsBase e)
    {
        if (report is null)
        {
            return;
        }

        ((Dictionary<string, object>)e.GlobalData[ProxyUtils.ReportsKey])[Name] = report;
    }
}
