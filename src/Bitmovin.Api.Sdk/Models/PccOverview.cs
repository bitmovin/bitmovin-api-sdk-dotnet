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
    /// PccOverview
    /// </summary>
    public class PccOverview
    {
        /// <summary>
        /// Number of selected cells, one per device pool and codec/protection combination. (required)
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Selected cells with a device-answering verdict, including refusals. (required)
        /// </summary>
        [JsonProperty(PropertyName = "answered")]
        public decimal? Answered { get; set; }

        /// <summary>
        /// Selected cells that played successfully. (required)
        /// </summary>
        [JsonProperty(PropertyName = "played")]
        public decimal? Played { get; set; }
    }
}
