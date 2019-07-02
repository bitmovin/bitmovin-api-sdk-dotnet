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
    /// LiveDashManifest
    /// </summary>

    public class LiveDashManifest
    {
        /// <summary>
        /// Dash manifest ids (required)
        /// </summary>
        [JsonProperty(PropertyName = "manifestId")]
        public string ManifestId { get; set; }
        
        /// <summary>
        /// Timeshift in seconds
        /// </summary>
        [JsonProperty(PropertyName = "timeshift")]
        public double? Timeshift { get; set; }
        
        /// <summary>
        /// Live edge offset in seconds
        /// </summary>
        [JsonProperty(PropertyName = "liveEdgeOffset")]
        public double? LiveEdgeOffset { get; set; }
    }

}
