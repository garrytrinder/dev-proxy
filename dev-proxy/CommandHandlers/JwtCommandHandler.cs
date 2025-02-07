// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using Microsoft.DevProxy.Jwt;

namespace Microsoft.DevProxy.CommandHandlers;

internal static class JwtCommandHandler
{
    internal static void GetToken(JwtOptions jwtOptions)
    {
        var token = JwtTokenGenerator.CreateToken(jwtOptions);

        Console.WriteLine(token);
    }
}
