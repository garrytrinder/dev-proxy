// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Security.Cryptography.X509Certificates;
using Microsoft.DevProxy.Abstractions;
using Microsoft.DevProxy.Abstractions.LanguageModel;

namespace Microsoft.DevProxy;

internal class ProxyContext(IProxyConfiguration configuration, X509Certificate2? certificate, ILanguageModelClient languageModelClient) : IProxyContext
{
    public IProxyConfiguration Configuration { get; } = configuration ?? throw new ArgumentNullException(nameof(configuration));
    public X509Certificate2? Certificate { get; } = certificate;
    public ILanguageModelClient LanguageModelClient { get; } = languageModelClient;
}
