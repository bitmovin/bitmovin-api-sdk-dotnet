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
    /// NexGuardFileMarker
    /// </summary>
    public class NexGuardFileMarker : BitmovinResource
    {
        /// <summary>
        /// Use the base64 license string that Nagra provides you. (required)
        /// </summary>
        [JsonProperty(PropertyName = "license")]
        public string License { get; set; }

        /// <summary>
        /// The type of watermarking to be used. Usually, OTT is the one recommended in production.
        /// </summary>
        [JsonProperty(PropertyName = "watermarkType")]
        public NexGuardWatermarkingType? WatermarkType { get; set; }

        /// <summary>
        /// Specify the payload ID that you want to be associated with this output. Valid values vary depending on your Nagra NexGuard forensic watermarking workflow. For PreRelease Content (NGPR), specify an integer from 1 through 4,194,303. You must generate a unique ID for each asset you watermark, and keep a record of th ID. Neither Nagra nor Bitmovin keep track of this for you.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public int? Payload { get; set; }

        /// <summary>
        /// Enter one of the watermarking preset strings that Nagra provides you.
        /// </summary>
        [JsonProperty(PropertyName = "preset")]
        public string Preset { get; set; }

        /// <summary>
        /// Optional. Ignore this setting unless Nagra support directs you to specify a value. When you don&#39;t specify a value here, the Nagra NexGuard library uses its default value.
        /// </summary>
        [JsonProperty(PropertyName = "strength")]
        public NexGuardWatermarkingStrength? Strength { get; set; }
    }
}
