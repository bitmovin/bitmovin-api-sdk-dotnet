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
        /// Input location of the SCC file (required)
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public InputPath Input { get; set; }

        /// <summary>
        /// SmpteTimecodeFlavor
        /// </summary>
        [JsonProperty(PropertyName = "smpteTimecodeFlavor")]
        public SmpteTimecodeFlavor? SmpteTimecodeFlavor { get; set; }
    }
}
