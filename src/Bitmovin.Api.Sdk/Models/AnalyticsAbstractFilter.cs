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
    /// AnalyticsAbstractFilter
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "operator")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsInFilter), "IN")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsEqualFilter), "EQ")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsNotEqualFilter), "NE")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsLessThanFilter), "LT")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsLessThanOrEqualFilter), "LTE")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsGreaterThanFilter), "GT")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsGreaterThanOrEqualFilter), "GTE")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsContainsFilter), "CONTAINS")]
    [JsonSubtypes.KnownSubType(typeof(AnalyticsNotContainsFilter), "NOTCONTAINS")]

    public class AnalyticsAbstractFilter
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public AnalyticsAttribute? Name { get; set; }
    }
}
