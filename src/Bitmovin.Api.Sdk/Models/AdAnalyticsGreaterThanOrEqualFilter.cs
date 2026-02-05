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
    /// AdAnalyticsGreaterThanOrEqualFilter
    /// </summary>
    public class AdAnalyticsGreaterThanOrEqualFilter : AdAnalyticsAbstractFilter
    {
        [JsonProperty(PropertyName = "operator")]
#pragma warning disable CS0414
        private readonly string _operator = "GTE";
#pragma warning restore CS0414

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public Object Value { get; set; }
    }
}
