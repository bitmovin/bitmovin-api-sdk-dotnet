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
    /// AkamaiAccountRegionSettings
    /// </summary>
    public class AkamaiAccountRegionSettings : BitmovinResource
    {
        /// <summary>
        /// Id of the VPC subnet for encoding instances (required)
        /// </summary>
        [JsonProperty(PropertyName = "subnetId")]
        public long? SubnetId { get; set; }

        /// <summary>
        /// Id of the firewall for encoding instances (required)
        /// </summary>
        [JsonProperty(PropertyName = "firewallId")]
        public long? FirewallId { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public AkamaiCloudRegion? Region { get; internal set; }
    }
}
