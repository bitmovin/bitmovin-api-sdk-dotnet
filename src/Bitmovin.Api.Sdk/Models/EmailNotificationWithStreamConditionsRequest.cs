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
    /// EmailNotificationWithStreamConditionsRequest
    /// </summary>
    public class EmailNotificationWithStreamConditionsRequest
    {
        /// <summary>
        /// Notify when condition resolves after it was met
        /// </summary>
        [JsonProperty(PropertyName = "resolve")]
        public bool? Resolve { get; set; }

        /// <summary>
        /// Emails
        /// </summary>
        [JsonProperty(PropertyName = "emails")]
        public List<string> Emails { get; set; } = new List<string>();

        /// <summary>
        /// Muted
        /// </summary>
        [JsonProperty(PropertyName = "muted")]
        public bool? Muted { get; set; }

        /// <summary>
        /// Conditions
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public AbstractCondition Conditions { get; set; }
    }
}
