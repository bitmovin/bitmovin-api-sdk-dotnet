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
    /// AkamaiMslOutput
    /// </summary>
    public class AkamaiMslOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "AKAMAI_MSL";
#pragma warning restore CS0414

        /// <summary>
        /// The Akamai stream ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public int? StreamId { get; set; }

        /// <summary>
        /// The Akamai event name (required)
        /// </summary>
        [JsonProperty(PropertyName = "eventName")]
        public string EventName { get; set; }

        /// <summary>
        /// - DASH: configure the Encoding with fMP4 or CMAF muxings and a DASH manifest. - HLS: configure the Encoding with TS muxings and an HLS manifest. - CMAF: configure the Encoding with fMP4 or CMAF muxings with both DASH and HLS manifests. (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamFormat")]
        public AkamaiMslStreamFormat? StreamFormat { get; set; }

        /// <summary>
        /// The Akamai MSL Version. Only MSL4 is supported at the moment. (required)
        /// </summary>
        [JsonProperty(PropertyName = "mslVersion")]
        public AkamaiMslVersion? MslVersion { get; set; }
    }
}
