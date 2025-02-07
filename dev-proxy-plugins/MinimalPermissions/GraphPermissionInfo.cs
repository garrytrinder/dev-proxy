// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Plugins.MinimalPermissions;

internal class GraphPermissionInfo
{
    public string Value { get; set; } = string.Empty;
    public string ScopeType { get; set; } = string.Empty;
    public string ConsentDisplayName { get; set; } = string.Empty;
    public string ConsentDescription { get; set; } = string.Empty;
    public bool IsAdmin { get; set; }
    public bool IsLeastPrivilege { get; set; }
    public bool IsHidden { get; set; }
}