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
    /// InterlaceFilter
    /// </summary>

    public class InterlaceFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "INTERLACE";

        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public InterlaceMode? Mode { get; set; }
        
        /// <summary>
        /// VerticalLowPassFilteringMode
        /// </summary>
        [JsonProperty(PropertyName = "verticalLowPassFilteringMode")]
        public VerticalLowPassFilteringMode? VerticalLowPassFilteringMode { get; set; }
    }

}
