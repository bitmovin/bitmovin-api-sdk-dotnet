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
    /// AnalyticsContextDescription
    /// </summary>

    public class AnalyticsContextDescription
    {
        /// <summary>
        /// Label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

}
