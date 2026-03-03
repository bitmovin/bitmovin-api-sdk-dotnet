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
    /// AgentChatAttachmentsPart
    /// </summary>
    public class AgentChatAttachmentsPart : AgentChatMessagePart
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "data-attachments";
#pragma warning restore CS0414

        /// <summary>
        /// Attachment payload (required)
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public AgentChatAttachmentsData Data { get; set; }
    }
}
