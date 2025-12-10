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
    /// Details about an individual ingestPoint within the live ingest.
    /// </summary>
    public class LiveEncodingHeartbeatIngestPoint
    {
        /// <summary>
        /// The name of the ingestPoint of the original Input resource. 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Id of the original Input resource. Note that multiple input points (main and backup) can be part of a single Input resource. 
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// InputType
        /// </summary>
        [JsonProperty(PropertyName = "inputType")]
        public InputType? InputType { get; set; }

        /// <summary>
        /// Indicates whether this particular input is active.
        /// </summary>
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Indicates whether this particular input is a backup input.
        /// </summary>
        [JsonProperty(PropertyName = "isBackup")]
        public bool? IsBackup { get; set; }
    }
}
