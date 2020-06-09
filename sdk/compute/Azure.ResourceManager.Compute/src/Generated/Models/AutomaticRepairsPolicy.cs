// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the configuration parameters for automatic repairs on the virtual machine scale set. </summary>
    public partial class AutomaticRepairsPolicy
    {
        /// <summary> Initializes a new instance of AutomaticRepairsPolicy. </summary>
        public AutomaticRepairsPolicy()
        {
        }

        /// <summary> Initializes a new instance of AutomaticRepairsPolicy. </summary>
        /// <param name="enabled"> Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is false. </param>
        /// <param name="gracePeriod"> The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should be specified in ISO 8601 format. The minimum allowed grace period is 30 minutes (PT30M), which is also the default value. The maximum allowed grace period is 90 minutes (PT90M). </param>
        internal AutomaticRepairsPolicy(bool? enabled, string gracePeriod)
        {
            Enabled = enabled;
            GracePeriod = gracePeriod;
        }

        /// <summary> Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is false. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should be specified in ISO 8601 format. The minimum allowed grace period is 30 minutes (PT30M), which is also the default value. The maximum allowed grace period is 90 minutes (PT90M). </summary>
        public string GracePeriod { get; set; }
    }
}