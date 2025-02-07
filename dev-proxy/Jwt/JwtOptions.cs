// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Microsoft.DevProxy.Jwt;

public class JwtOptions
{
    public string? Name { get; set; }
    public IEnumerable<string>? Audiences { get; set; }
    public string? Issuer { get; set; }
    public IEnumerable<string>? Roles { get; set; }
    public IEnumerable<string>? Scopes { get; set; }
    public Dictionary<string, string>? Claims { get; set; }
    public double? ValidFor { get; set; }
    public string? SigningKey { get; set; }
}
