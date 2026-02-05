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
    /// EnhancedDeinterlaceFilter
    /// </summary>
    public class EnhancedDeinterlaceFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "ENHANCED_DEINTERLACE";
#pragma warning restore CS0414

        /// <summary>
        /// Parity
        /// </summary>
        [JsonProperty(PropertyName = "parity")]
        public EnhancedDeinterlaceParity? Parity { get; set; }

        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public EnhancedDeinterlaceMode? Mode { get; set; }

        /// <summary>
        /// AutoEnable
        /// </summary>
        [JsonProperty(PropertyName = "autoEnable")]
        public EnhancedDeinterlaceAutoEnable? AutoEnable { get; set; }
    }
}
