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
    /// PlaintextId3Tag
    /// </summary>

    public class PlaintextId3Tag : Id3Tag
    {
        /// <summary>
        /// Plain Text Data (required)
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <summary>
        /// 4 character long Frame ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "frameId")]
        public string FrameId { get; set; }
    }

}
