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
    /// AgentSessionResponse
    /// </summary>
    public class AgentSessionResponse
    {
        /// <summary>
        /// Session ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Agent application name (required)
        /// </summary>
        [JsonProperty(PropertyName = "appName")]
        public string AppName { get; set; }

        /// <summary>
        /// User ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
    }
}
