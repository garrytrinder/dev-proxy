// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Plugins.MinimalPermissions;

public class ApiOperation
{
    public required string Method { get; init; }
    public required string OriginalUrl { get; init; }
    public required string TokenizedUrl { get; init; }
}