// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The service properties for soft delete. </summary>
    public partial class DeleteRetentionPolicy
    {
        /// <summary> Initializes a new instance of DeleteRetentionPolicy. </summary>
        public DeleteRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of DeleteRetentionPolicy. </summary>
        /// <param name="enabled"> Indicates whether DeleteRetentionPolicy is enabled. </param>
        /// <param name="days"> Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365. </param>
        internal DeleteRetentionPolicy(bool? enabled, int? days)
        {
            Enabled = enabled;
            Days = days;
        }

        /// <summary> Indicates whether DeleteRetentionPolicy is enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365. </summary>
        public int? Days { get; set; }
    }
}