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
    /// AgentChatMessage
    /// </summary>
    public class AgentChatMessage
    {
        /// <summary>
        /// Message ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Message role (required)
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Message parts (required)
        /// </summary>
        [JsonProperty(PropertyName = "parts")]
        public List<AgentChatMessagePart> Parts { get; set; } = new List<AgentChatMessagePart>();
    }
}
