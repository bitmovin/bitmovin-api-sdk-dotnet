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
    /// ResponseErrorData
    /// </summary>
    public class ResponseErrorData
    {
        /// <summary>
        /// Contains an error code as defined in https://bitmovin.com/encoding-documentation/bitmovin-api/#/introduction/api-error-codes (required)
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; internal set; }

        /// <summary>
        /// General error message (required)
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; internal set; }

        /// <summary>
        /// More detailed message meant for developers (required)
        /// </summary>
        [JsonProperty(PropertyName = "developerMessage")]
        public string DeveloperMessage { get; internal set; }

        /// <summary>
        /// collection of links to webpages containing further information on the topic
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public List<Link> Links { get; internal set; } = new List<Link>();

        /// <summary>
        /// collection of messages containing more detailed information on the cause of the error
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public List<Message> Details { get; internal set; } = new List<Message>();
    }
}
