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
    /// AnalyticsFilter
    /// </summary>

    public class AnalyticsFilter
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public AnalyticsOperator Operator { get; set; }
        
        /// <summary>
        /// The value to compare to the property specified by the name
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }

}
