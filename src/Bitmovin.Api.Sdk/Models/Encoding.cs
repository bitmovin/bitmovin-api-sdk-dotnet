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
    /// Encoding
    /// </summary>
    public class Encoding : BitmovinResource
    {
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// Specify a list of regions which are used in case the preferred region is down. Currently there are several restrictions. - The region has to be specific or AUTO - The region has to be for the same cloud provider as the default one - You can only configure at most 3 fallback regions 
        /// </summary>
        [JsonProperty(PropertyName = "fallbackCloudRegions")]
        public List<CloudRegion> FallbackCloudRegions { get; set; } = new List<CloudRegion>();

        /// <summary>
        /// Version of the encoder
        /// </summary>
        [JsonProperty(PropertyName = "encoderVersion")]
        public string EncoderVersion { get; set; }

        /// <summary>
        /// Define an external infrastructure to run the encoding on. Note If you set this value, the &#x60;cloudRegion&#x60; must be &#39;EXTERNAL&#39;.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }

        /// <summary>
        /// Infrastructure
        /// </summary>
        [JsonProperty(PropertyName = "infrastructure")]
        public InfrastructureSettings Infrastructure { get; set; }

        /// <summary>
        /// Will be set to the encoder version that was actually used for the encoding. This is especially useful when starting an encoding with a version tag like STABLE or BETA.
        /// </summary>
        [JsonProperty(PropertyName = "selectedEncoderVersion")]
        public string SelectedEncoderVersion { get; internal set; }

        /// <summary>
        /// Will be set to the encoding mode that was actually used for the encoding. This is especially useful when starting an encoding with encoding mode STANDARD.
        /// </summary>
        [JsonProperty(PropertyName = "selectedEncodingMode")]
        public EncodingMode? SelectedEncodingMode { get; internal set; }

        /// <summary>
        /// Contains the region which was selected when cloudregion:AUTO was specified
        /// </summary>
        [JsonProperty(PropertyName = "selectedCloudRegion")]
        public CloudRegion? SelectedCloudRegion { get; internal set; }

        /// <summary>
        /// The current status of the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; internal set; }

        /// <summary>
        /// You may pass a list of groups associated with this encoding. This will enable you to group results in the statistics resource
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public List<string> Labels { get; set; } = new List<string>();
    }
}
