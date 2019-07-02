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
        /// StreamFormat
        /// </summary>
        [JsonProperty(PropertyName = "streamFormat")]
        public AkamaiMslStreamFormat? StreamFormat { get; set; }
        
        /// <summary>
        /// MslVersion
        /// </summary>
        [JsonProperty(PropertyName = "mslVersion")]
        public AkamaiMslVersion? MslVersion { get; set; }
    }

}
