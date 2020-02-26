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
    /// SccCaption
    /// </summary>
    public class SccCaption : BitmovinResource
    {
        /// <summary>
        /// The input location to get the scc file from (required)
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public InputPath Input { get; set; }
    }
}
