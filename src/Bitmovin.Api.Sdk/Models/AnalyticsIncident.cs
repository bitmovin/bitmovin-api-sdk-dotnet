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
    /// AnalyticsIncident
    /// </summary>
    public class AnalyticsIncident
    {
        /// <summary>
        /// Incident id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Rule Id
        /// </summary>
        [JsonProperty(PropertyName = "ruleId")]
        public string RuleId { get; set; }

        /// <summary>
        /// Start date of the incident
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }

        /// <summary>
        /// End date of the incident
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }

        /// <summary>
        /// Recovery state of incident
        /// </summary>
        [JsonProperty(PropertyName = "isRecovered")]
        public bool? IsRecovered { get; set; }
    }
}
