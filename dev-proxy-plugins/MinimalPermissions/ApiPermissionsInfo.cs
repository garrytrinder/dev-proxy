// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Plugins.MinimalPermissions;

public class ApiPermissionsInfo
{
    public required List<string> TokenPermissions { get; init; }
    public required List<ApiOperation> OperationsFromRequests { get; init; }
    public required string[] MinimalScopes { get; init; }
    public required string[] UnmatchedOperations { get; init; }
    public required List<ApiPermissionError> Errors { get; init; }
}