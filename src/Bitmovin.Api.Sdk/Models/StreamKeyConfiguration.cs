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
    /// StreamKeyConfiguration
    /// </summary>
    public class StreamKeyConfiguration
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public StreamKeyConfigurationType? Type { get; set; }

        /// <summary>
        /// Id of the previously generated stream key.  Only needed when the type is &#x60;ASSIGN&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "streamKeyId")]
        public string StreamKeyId { get; set; }
    }
}
