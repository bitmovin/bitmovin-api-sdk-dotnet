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
    /// Webhook
    /// </summary>
    public class Webhook : BitmovinResource
    {
        /// <summary>
        /// Webhook url (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// HTTP method used for the webhook
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public WebhookHttpMethod? Method { get; set; }

        /// <summary>
        /// Whether to skip SSL certification verification or not
        /// </summary>
        [JsonProperty(PropertyName = "insecureSsl")]
        public bool? InsecureSsl { get; set; }

        /// <summary>
        /// Signature used for the webhook
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        public WebhookSignature Signature { get; set; }

        /// <summary>
        /// The json schema of the data that is send as webhook payload
        /// </summary>
        [JsonProperty(PropertyName = "schema")]
        public Object Schema { get; internal set; }
    }
}
