// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.CommandLine;

namespace Microsoft.DevProxy.Abstractions;

public interface IProxyPlugin
{
    string Name { get; }
    Option[] GetOptions();
    Command[] GetCommands();
    Task RegisterAsync();
}
