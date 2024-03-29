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
    /// SimpleEncodingVodJobCdnOutput
    /// </summary>
    public class SimpleEncodingVodJobCdnOutput : SimpleEncodingVodJobOutput
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "CDN";

        /// <summary>
        /// The maximum output resolution to be generated
        /// </summary>
        [JsonProperty(PropertyName = "maxResolution")]
        public SimpleEncodingLiveMaxResolution? MaxResolution { get; set; }
    }
}
