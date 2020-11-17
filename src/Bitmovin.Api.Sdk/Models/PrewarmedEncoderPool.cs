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
    /// PrewarmedEncoderPool
    /// </summary>
    public class PrewarmedEncoderPool : BitmovinResource
    {
        /// <summary>
        /// The encoder version which the pool&#39;s instances will be running (required)
        /// </summary>
        [JsonProperty(PropertyName = "encoderVersion")]
        public string EncoderVersion { get; set; }

        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// Define an external infrastructure to run the pool on.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }

        /// <summary>
        /// DiskSize
        /// </summary>
        [JsonProperty(PropertyName = "diskSize")]
        public PrewarmedEncoderDiskSize? DiskSize { get; set; }

        /// <summary>
        /// Number of instances to keep prewarmed while the pool is running (required)
        /// </summary>
        [JsonProperty(PropertyName = "targetPoolSize")]
        public int? TargetPoolSize { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public PrewarmedEncoderPoolStatus? Status { get; set; }
    }
}
