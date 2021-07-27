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
    /// GceAccountRegionSettings
    /// </summary>
    public class GceAccountRegionSettings : BitmovinResource
    {
        /// <summary>
        /// Id of the network for encoding instances (required)
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string Network { get; set; }

        /// <summary>
        /// Id of the subnet for encoding instances (required)
        /// </summary>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public GoogleCloudRegion? Region { get; internal set; }
    }
}
