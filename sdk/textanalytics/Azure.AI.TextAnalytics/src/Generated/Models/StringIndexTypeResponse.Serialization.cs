// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    internal static class StringIndexTypeResponseExtensions
    {
        public static string ToSerialString(this StringIndexTypeResponse value) => value switch
        {
            StringIndexTypeResponse.TextElementsV8 => "TextElements_v8",
            StringIndexTypeResponse.UnicodeCodePoint => "UnicodeCodePoint",
            StringIndexTypeResponse.Utf16CodeUnit => "Utf16CodeUnit",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StringIndexTypeResponse value.")
        };

        public static StringIndexTypeResponse ToStringIndexTypeResponse(this string value)
        {
            if (string.Equals(value, "TextElements_v8", StringComparison.InvariantCultureIgnoreCase)) return StringIndexTypeResponse.TextElementsV8;
            if (string.Equals(value, "UnicodeCodePoint", StringComparison.InvariantCultureIgnoreCase)) return StringIndexTypeResponse.UnicodeCodePoint;
            if (string.Equals(value, "Utf16CodeUnit", StringComparison.InvariantCultureIgnoreCase)) return StringIndexTypeResponse.Utf16CodeUnit;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StringIndexTypeResponse value.");
        }
    }
}
