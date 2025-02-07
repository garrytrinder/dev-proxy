// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

#pragma warning disable IDE0130
namespace Microsoft.Extensions.Logging;
#pragma warning restore IDE0130

public static class ILoggerExtensions
{
    public static IDisposable? BeginScope(this ILogger logger, string method, string url, int requestId) =>
      logger.BeginScope(new Dictionary<string, object>
      {
          { nameof(method), method },
          { nameof(url), url },
          { nameof(requestId), requestId }
      });
}