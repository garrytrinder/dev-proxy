// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Text.RegularExpressions;

namespace Microsoft.DevProxy;

static class Announcement
{
    private static readonly string announcementUrl = "https://aka.ms/devproxy/announcement";

    public static async Task ShowAsync()
    {
        var announcement = await GetAsync();
        if (!string.IsNullOrEmpty(announcement))
        {
            // Unescape the announcement to remove any escape characters
            // in case we're using ANSI escape codes for color formatting
            announcement = Regex.Unescape(announcement);
            await Console.Error.WriteLineAsync(announcement);
        }
    }

    public static async Task<string?> GetAsync()
    {
        try
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(announcementUrl);
        }
        catch
        {
            return null;
        }
    }
}