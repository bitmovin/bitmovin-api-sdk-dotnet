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
    /// AnalyticsAlertingNotification
    /// </summary>
    public class AnalyticsAlertingNotification
    {
        /// <summary>
        /// List of email addresses
        /// </summary>
        [JsonProperty(PropertyName = "emails")]
        public List<string> Emails { get; set; } = new List<string>();

        /// <summary>
        /// Webhooks
        /// </summary>
        [JsonProperty(PropertyName = "webhooks")]
        public List<AnalyticsAlertingWebhook> Webhooks { get; set; } = new List<AnalyticsAlertingWebhook>();
    }
}
