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
    /// AnalyticsErrorDetailsResponse
    /// </summary>
    public class AnalyticsErrorDetailsResponse
    {
        /// <summary>
        /// ErrorDetails
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public List<AnalyticsErrorDetail> ErrorDetails { get; set; } = new List<AnalyticsErrorDetail>();
    }
}
