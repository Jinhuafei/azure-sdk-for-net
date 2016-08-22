// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response for CheckIPAddressAvailability Api service call
    /// </summary>
    public partial class IPAddressAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the IPAddressAvailabilityResult
        /// class.
        /// </summary>
        public IPAddressAvailabilityResult() { }

        /// <summary>
        /// Initializes a new instance of the IPAddressAvailabilityResult
        /// class.
        /// </summary>
        public IPAddressAvailabilityResult(bool? available = default(bool?), IList<string> availableIPAddresses = default(IList<string>))
        {
            Available = available;
            AvailableIPAddresses = availableIPAddresses;
        }

        /// <summary>
        /// Private IP address availability
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool? Available { get; set; }

        /// <summary>
        /// Contains other available private IP addresses if the asked for
        /// address is taken
        /// </summary>
        [JsonProperty(PropertyName = "availableIPAddresses")]
        public IList<string> AvailableIPAddresses { get; set; }

    }
}
