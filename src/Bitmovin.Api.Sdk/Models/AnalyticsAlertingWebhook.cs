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
    /// AnalyticsAlertingWebhook
    /// </summary>
    public class AnalyticsAlertingWebhook
    {
        /// <summary>
        /// Webhook url (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// HTTP method used for the webhook (required)
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public WebhookHttpMethod? Method { get; set; }

        /// <summary>
        /// Whether to skip SSL certification verification or not (required)
        /// </summary>
        [JsonProperty(PropertyName = "insecureSsl")]
        public bool? InsecureSsl { get; set; }
    }
}
