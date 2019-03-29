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
    /// CaptionsEmbedCea
    /// </summary>

    public class CaptionsEmbedCea : BitmovinResource
    {
        /// <summary>
        /// Select the channel for the caption information
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public int? Channel { get; set; }
        
        /// <summary>
        /// The input stream to extract the subtitle from
        /// </summary>
        [JsonProperty(PropertyName = "inputStream")]
        public InputStream InputStream { get; set; }
    }

}
