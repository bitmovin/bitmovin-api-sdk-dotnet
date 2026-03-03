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
    /// AgentChatAttachment
    /// </summary>
    public class AgentChatAttachment
    {
        /// <summary>
        /// Attachment kind (required)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Tool call identifier
        /// </summary>
        [JsonProperty(PropertyName = "toolCallId")]
        public string ToolCallId { get; set; }

        /// <summary>
        /// Attachment attributes map (required)
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public Dictionary<string, Object> Attributes { get; set; } = new Dictionary<string, Object>();
    }
}
