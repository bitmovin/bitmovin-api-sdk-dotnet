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
    /// AgentSessionListItem
    /// </summary>
    public class AgentSessionListItem
    {
        /// <summary>
        /// Session ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Session title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Last update time in seconds
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTimeSeconds")]
        public double? LastUpdateTimeSeconds { get; set; }
    }
}
