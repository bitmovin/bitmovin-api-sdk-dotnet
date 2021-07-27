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
        private readonly string _type = "AKAMAI_MSL";

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
        /// The stream format. Only DASH is supported at the moment. (required)
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
