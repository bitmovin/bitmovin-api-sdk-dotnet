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
    /// InsertableContent
    /// </summary>

    public class InsertableContent : BitmovinResource
    {
        /// <summary>
        /// List of video files to be inserted in the live stream. These have to match the codec, aspect ration and frame rate of the live stream.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public List<InsertableContentInput> Inputs { get; set; } = new List<InsertableContentInput>();
        
        /// <summary>
        /// Status of the insertable content.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InsertableContentStatus? Status { get; internal set; }
    }

}
