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
    /// OciAccountRegionSettings
    /// </summary>
    public class OciAccountRegionSettings : BitmovinResource
    {
        /// <summary>
        /// Id of the VPC subnet for encoding instances. (required)
        /// </summary>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Region for encoding instances.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public OciCloudRegion? Region { get; internal set; }
    }
}
