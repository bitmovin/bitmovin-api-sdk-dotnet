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
    /// AdAnalyticsEqualFilter
    /// </summary>
    public class AdAnalyticsEqualFilter : AdAnalyticsAbstractFilter
    {
        [JsonProperty(PropertyName = "operator")]
        private readonly string _operator = "EQ";

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public Object Value { get; set; }
    }
}
