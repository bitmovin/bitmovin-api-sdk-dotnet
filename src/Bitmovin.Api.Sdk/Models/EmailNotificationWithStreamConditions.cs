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
    /// EmailNotificationWithStreamConditions
    /// </summary>

    public class EmailNotificationWithStreamConditions : EmailNotification
    {
        /// <summary>
        /// Conditions
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public List<StreamCondition> Conditions { get; set; }
    }

}
