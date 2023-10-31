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
    /// LiveHlsManifest
    /// </summary>
    public class LiveHlsManifest
    {
        /// <summary>
        /// HLS manifest id (required)
        /// </summary>
        [JsonProperty(PropertyName = "manifestId")]
        public string ManifestId { get; set; }

        /// <summary>
        /// Timeshift in seconds. We recommend to use a timeshift value not greater than 3 hours (10800.0 seconds). Longer values could negatively impact the manifest update frequency. 
        /// </summary>
        [JsonProperty(PropertyName = "timeshift")]
        public double? Timeshift { get; set; }

        /// <summary>
        /// Live edge offset in seconds
        /// </summary>
        [JsonProperty(PropertyName = "liveEdgeOffset")]
        public double? LiveEdgeOffset { get; set; }

        /// <summary>
        /// Specifies if the EXT-X-PROGRAM-DATETIME tag will be included
        /// </summary>
        [JsonProperty(PropertyName = "insertProgramDateTime")]
        public bool? InsertProgramDateTime { get; set; }

        /// <summary>
        /// Configuration for the EXT-X-PROGRAM-DATETIME tag
        /// </summary>
        [JsonProperty(PropertyName = "programDateTimeSettings")]
        public ProgramDateTimeSettings ProgramDateTimeSettings { get; set; }
    }
}
