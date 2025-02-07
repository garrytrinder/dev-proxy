// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Plugins.MinimalPermissions;

public class ApiPermissionError
{
    public required string Request { get; init; }
    public required string Error { get; init; }
}
