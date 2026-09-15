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
    /// PccSupportShare
    /// </summary>
    public class PccSupportShare
    {
        /// <summary>
        /// What this share counts, in words rather than in codes. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Device pools that played it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "played")]
        public decimal? Played { get; set; }

        /// <summary>
        /// Device pools that answered either way. The denominator, never the fleet size. (required)
        /// </summary>
        [JsonProperty(PropertyName = "measured")]
        public decimal? Measured { get; set; }
    }
}
