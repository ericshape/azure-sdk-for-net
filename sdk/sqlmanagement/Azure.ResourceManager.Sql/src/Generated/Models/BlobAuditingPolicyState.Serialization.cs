// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static class BlobAuditingPolicyStateExtensions
    {
        public static string ToSerialString(this BlobAuditingPolicyState value) => value switch
        {
            BlobAuditingPolicyState.Enabled => "Enabled",
            BlobAuditingPolicyState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobAuditingPolicyState value.")
        };

        public static BlobAuditingPolicyState ToBlobAuditingPolicyState(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return BlobAuditingPolicyState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return BlobAuditingPolicyState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobAuditingPolicyState value.");
        }
    }
}