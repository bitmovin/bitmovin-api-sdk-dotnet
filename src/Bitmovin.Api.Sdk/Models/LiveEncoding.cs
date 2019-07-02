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
    /// LiveEncoding
    /// </summary>

    public class LiveEncoding
    {
        /// <summary>
        /// Stream key of the live encoder (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; set; }
        
        /// <summary>
        /// IP address of the live encoder (required)
        /// </summary>
        [JsonProperty(PropertyName = "encoderIp")]
        public string EncoderIp { get; set; }
    }

}
