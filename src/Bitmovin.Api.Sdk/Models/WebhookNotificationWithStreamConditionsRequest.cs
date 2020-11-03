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
    /// WebhookNotificationWithStreamConditionsRequest
    /// </summary>
    public class WebhookNotificationWithStreamConditionsRequest : WebhookNotification
    {
        /// <summary>
        /// Conditions
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public AbstractCondition Conditions { get; set; }
    }
}
