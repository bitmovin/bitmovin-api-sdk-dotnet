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
    /// PrewarmEncoderSettings
    /// </summary>

    public class PrewarmEncoderSettings : BitmovinResource
    {
        /// <summary>
        /// Encoder Version to be prewarmed. Only one encoder of this version can be prewarmed per cluster. (required)
        /// </summary>
        [JsonProperty(PropertyName = "encoderVersion")]
        public string EncoderVersion { get; set; }
        
        /// <summary>
        /// The minimum number of prewarmed encoders of this Version (required)
        /// </summary>
        [JsonProperty(PropertyName = "minPrewarmed")]
        public int? MinPrewarmed { get; set; }
        
        /// <summary>
        /// The maximum number of concurrent prewarmed encoders of this Version
        /// </summary>
        [JsonProperty(PropertyName = "maxPrewarmed")]
        public int? MaxPrewarmed { get; set; }
        
        /// <summary>
        /// LogLevel
        /// </summary>
        [JsonProperty(PropertyName = "logLevel")]
        public LogLevel? LogLevel { get; set; }
    }

}
