using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AzureAccountRegionSettings
    /// </summary>
    public class AzureAccountRegionSettings : BitmovinResource
    {
        /// <summary>
        /// Name of the virtual network (required)
        /// </summary>
        [JsonProperty(PropertyName = "networkName")]
        public string NetworkName { get; set; }

        /// <summary>
        /// Name of the subnet (required)
        /// </summary>
        [JsonProperty(PropertyName = "subnetName")]
        public string SubnetName { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public AzureCloudRegion? Region { get; set; }
    }
}
