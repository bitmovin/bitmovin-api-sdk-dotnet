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
    /// DashMuxingRepresentation
    /// </summary>
    public class DashMuxingRepresentation : DashRepresentation
    {
        /// <summary>
        /// UUID of an encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// UUID of a muxing (required)
        /// </summary>
        [JsonProperty(PropertyName = "muxingId")]
        public string MuxingId { get; set; }

        /// <summary>
        /// Used to signal a dependency with another representation. The representation may belong to a different adaptation set
        /// </summary>
        [JsonProperty(PropertyName = "dependencyId")]
        public string DependencyId { get; set; }
    }
}
