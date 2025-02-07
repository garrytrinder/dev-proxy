// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Plugins.MinimalPermissions;

internal class GraphResultsAndErrors
{
    public GraphPermissionInfo[]? Results { get; set; }
    public GraphPermissionError[]? Errors { get; set; }
}