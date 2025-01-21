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
    /// H264PerTitleConfiguration
    /// </summary>
    public class H264PerTitleConfiguration : PerTitleConfiguration
    {
        /// <summary>
        /// This factor doesn&#39;t have any impact!
        /// </summary>
        [JsonProperty(PropertyName = "codecMinBitrateFactor")]
        public double? CodecMinBitrateFactor { get; set; }

        /// <summary>
        /// This factor is used to calculate the maxBitrate of the codec configuration for the generated representations as a multiple of the targetBitrate
        /// </summary>
        [JsonProperty(PropertyName = "codecMaxBitrateFactor")]
        public double? CodecMaxBitrateFactor { get; set; }

        /// <summary>
        /// This factor is used to calculate the bufsize of the codec configuration for the generated representations as a multiple of the targetBitrate
        /// </summary>
        [JsonProperty(PropertyName = "codecBufsizeFactor")]
        public double? CodecBufsizeFactor { get; set; }
    }
}
