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
    /// AgentChatDynamicToolPart
    /// </summary>
    public class AgentChatDynamicToolPart : AgentChatMessagePart
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "dynamic-tool";
#pragma warning restore CS0414

        /// <summary>
        /// Tool name (required)
        /// </summary>
        [JsonProperty(PropertyName = "toolName")]
        public string ToolName { get; set; }

        /// <summary>
        /// Tool call identifier (required)
        /// </summary>
        [JsonProperty(PropertyName = "toolCallId")]
        public string ToolCallId { get; set; }

        /// <summary>
        /// Tool invocation lifecycle state (required)
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public AgentChatDynamicToolState? State { get; set; }

        /// <summary>
        /// Tool input payload.
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public Dictionary<string, Object> Input { get; set; } = new Dictionary<string, Object>();

        /// <summary>
        /// Tool output payload.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public Dictionary<string, Object> Output { get; set; } = new Dictionary<string, Object>();

        /// <summary>
        /// Error text for failed tool completion.
        /// </summary>
        [JsonProperty(PropertyName = "errorText")]
        public string ErrorText { get; set; }
    }
}
