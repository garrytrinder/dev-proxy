// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.CommandLine.Invocation;
using Microsoft.DevProxy.Abstractions;
using Microsoft.VisualStudio.Threading;

namespace Microsoft.DevProxy.CommandHandlers;

public class MSGraphDbCommandHandler(ILogger logger) : ICommandHandler
{
    private readonly ILogger _logger = logger;

    public int Invoke(InvocationContext context)
    {
        var joinableTaskContext = new JoinableTaskContext();
        var joinableTaskFactory = new JoinableTaskFactory(joinableTaskContext);
        
        return joinableTaskFactory.Run(async () => await InvokeAsync(context));
    }

    public async Task<int> InvokeAsync(InvocationContext context)
    {
        return await MSGraphDbUtils.GenerateMSGraphDbAsync(_logger);
    }
}
