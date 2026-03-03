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
    /// AgentChatAttachmentsData
    /// </summary>
    public class AgentChatAttachmentsData
    {
        /// <summary>
        /// Attachment list (required)
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public List<AgentChatAttachment> Attachments { get; set; } = new List<AgentChatAttachment>();
    }
}
