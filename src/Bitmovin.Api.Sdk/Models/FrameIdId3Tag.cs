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
    /// FrameIdId3Tag
    /// </summary>

    public class FrameIdId3Tag : Id3Tag
    {
        /// <summary>
        /// Base64 Encoded Data
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public string Bytes { get; set; }
        
        /// <summary>
        /// 4 character long Frame ID
        /// </summary>
        [JsonProperty(PropertyName = "frameId")]
        public string FrameId { get; set; }
    }

}
