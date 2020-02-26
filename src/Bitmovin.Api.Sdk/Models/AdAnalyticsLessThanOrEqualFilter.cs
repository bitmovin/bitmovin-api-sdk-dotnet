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
    /// AdAnalyticsLessThanOrEqualFilter
    /// </summary>
    public class AdAnalyticsLessThanOrEqualFilter : AdAnalyticsAbstractFilter
    {
        [JsonProperty(PropertyName = "operator")]
        private readonly string _operator = "LTE";

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public Object Value { get; set; }
    }
}
