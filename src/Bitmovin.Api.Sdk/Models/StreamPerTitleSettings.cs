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
    /// StreamPerTitleSettings
    /// </summary>
    public class StreamPerTitleSettings
    {
        /// <summary>
        /// Settings for PER_TITLE_TEMPLATE_FIXED_RESOLUTION_AND_BITRATE mode
        /// </summary>
        [JsonProperty(PropertyName = "fixedResolutionAndBitrateSettings")]
        public StreamPerTitleFixedResolutionAndBitrateSettings FixedResolutionAndBitrateSettings { get; set; }

        /// <summary>
        /// This factor is used to calculate the maxBitrate of the codec configuration for the generated representation as a multiple of the targetBitrate(generated by Per-Title algorithm). This value will take precedence over the &#39;codecMaxBitrateFactor&#39; from the pertitleStartConfiguration. This value will only have an impact on streams with h264 or h265 video configurations.
        /// </summary>
        [JsonProperty(PropertyName = "codecMaxBitrateFactor")]
        public double? CodecMaxBitrateFactor { get; set; }

        /// <summary>
        /// This factor is used to calculate the bufsize of the codec configuration for the generated representations as a multiple of the targetBitrate(generated by Per-Title algorithm). This value will take precedence over the &#39;codecBufsizeFactor&#39; from the pertitleStartConfiguration.. This value will only have an impact on streams with h264 or h265 video configurations.
        /// </summary>
        [JsonProperty(PropertyName = "codecBufsizeFactor")]
        public double? CodecBufsizeFactor { get; set; }
    }
}
