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
    /// Message
    /// </summary>
    public class Message : BitmovinResponse
    {
        /// <summary>
        /// Message type giving a hint on the importance of the message (log level) (required)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public MessageType? Type { get; set; }

        /// <summary>
        /// Message text (required)
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Name of the field to which the message is referring to
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        /// <summary>
        /// collection of links to webpages containing further information on the topic
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public List<Link> Links { get; set; } = new List<Link>();

        /// <summary>
        /// Service-specific information
        /// </summary>
        [JsonProperty(PropertyName = "more")]
        public Object More { get; set; }

        /// <summary>
        /// Timestamp when the message occurred
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }
    }
}
