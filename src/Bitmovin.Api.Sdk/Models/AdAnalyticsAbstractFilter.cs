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
    /// AdAnalyticsAbstractFilter
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "operator")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsInFilter), "IN")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsEqualFilter), "EQ")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsNotEqualFilter), "NE")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsLessThanFilter), "LT")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsLessThanOrEqualFilter), "LTE")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsGreaterThanFilter), "GT")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsGreaterThanOrEqualFilter), "GTE")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsContainsFilter), "CONTAINS")]
    [JsonSubtypes.KnownSubType(typeof(AdAnalyticsNotContainsFilter), "NOTCONTAINS")]

    public class AdAnalyticsAbstractFilter
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public AdAnalyticsAttribute? Name { get; set; }
    }
}
