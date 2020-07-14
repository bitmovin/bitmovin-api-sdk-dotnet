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
    /// DisplayAspectRatio
    /// </summary>
    public class DisplayAspectRatio
    {
        /// <summary>
        /// The numerator of the display aspect ratio (DAR). For example for a DAR of 16:9, the value 16 must be used. (required)
        /// </summary>
        [JsonProperty(PropertyName = "numerator")]
        public int? Numerator { get; set; }

        /// <summary>
        /// The denominator of the display aspect ratio (DAR). For example for a DAR of 16:9, the value 9 must be used. (required)
        /// </summary>
        [JsonProperty(PropertyName = "denominator")]
        public int? Denominator { get; set; }
    }
}
