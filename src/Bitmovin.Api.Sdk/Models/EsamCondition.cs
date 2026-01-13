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
    /// ESAM condition following the SCTE-250 standard with timing offset and directional marker (OUT/IN) for signaling content boundaries
    /// </summary>
    public class EsamCondition
    {
        /// <summary>
        /// The offset from the matched signal when this condition applies in ISO 8601 duration format, accurate to milliseconds (required)
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public string Offset { get; set; }

        /// <summary>
        /// Direction marker indicating the boundary type (OUT for start, IN for end) (required)
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public EsamDirection? Direction { get; set; }
    }
}
