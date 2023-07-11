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
        /// The cloud region in which the pool&#39;s instances will be running. Must be a specific region (e.g. not &#39;AUTO&#39;, &#39;GOOGLE&#39; or &#39;EUROPE&#39;) (required)
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// Define an external infrastructure to run the pool on.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }

        /// <summary>
        /// Disk size of the prewarmed instances in GB. Needs to be chosen depending on input file sizes and encoding features used. (required)
        /// </summary>
        [JsonProperty(PropertyName = "diskSize")]
        public PrewarmedEncoderDiskSize? DiskSize { get; set; }

        /// <summary>
        /// Number of instances to keep prewarmed while the pool is running (required)
        /// </summary>
        [JsonProperty(PropertyName = "targetPoolSize")]
        public int? TargetPoolSize { get; set; }

        /// <summary>
        /// Create pool with GPU instances for hardware encoding presets (e.g., VOD_HARDWARE_SHORTFORM).
        /// </summary>
        [JsonProperty(PropertyName = "gpuEnabled")]
        public bool? GpuEnabled { get; set; }

        /// <summary>
        /// Current status of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public PrewarmedEncoderPoolStatus? Status { get; internal set; }
    }
}
