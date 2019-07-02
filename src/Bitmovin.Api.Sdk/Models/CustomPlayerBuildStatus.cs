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
    /// CustomPlayerBuildStatus
    /// </summary>

    public class CustomPlayerBuildStatus
    {
        /// <summary>
        /// Status of the player build (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; set; }
        
        /// <summary>
        /// The estimated time span of the custom player build in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "eta")]
        public int? Eta { get; set; }
        
        /// <summary>
        /// The actual progress of the custom player build. (required)
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; set; }
        
        /// <summary>
        /// Messages
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public Message Messages { get; set; }
        
        /// <summary>
        /// Subtasks
        /// </summary>
        [JsonProperty(PropertyName = "subtasks")]
        public string Subtasks { get; set; }
    }

}
