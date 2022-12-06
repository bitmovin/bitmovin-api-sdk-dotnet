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
    /// SimpleEncodingLiveJobOutput
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingLiveJobUrlOutput), "URL")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingLiveJobCdnOutput), "CDN")]

    public class SimpleEncodingLiveJobOutput
    {
        /// <summary>
        /// The maximum output resolution to be generated
        /// </summary>
        [JsonProperty(PropertyName = "maxResolution")]
        public SimpleEncodingLiveMaxResolution? MaxResolution { get; set; }
    }
}
