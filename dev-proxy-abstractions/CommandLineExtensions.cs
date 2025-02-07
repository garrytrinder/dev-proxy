// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.CommandLine;
using System.CommandLine.Parsing;

namespace Microsoft.DevProxy.Abstractions;

public static class CommandLineExtensions
{
    public static T? GetValueForOption<T>(this ParseResult parseResult, string optionName, Option[] options)
    {
        // we need to remove the leading - because CommandLine stores the option
        // name without them
        if (options
            .FirstOrDefault(o => o.Name == optionName.TrimStart('-')) is not Option<T> option)
        {
            throw new InvalidOperationException($"Could not find option with name {optionName} and value type {typeof(T).Name}");
        }

        return parseResult.GetValueForOption(option);
    }
}
