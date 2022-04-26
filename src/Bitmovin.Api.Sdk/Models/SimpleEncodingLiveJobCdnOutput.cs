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
    /// SimpleEncodingLiveJobCdnOutput
    /// </summary>
    public class SimpleEncodingLiveJobCdnOutput : SimpleEncodingLiveJobOutput
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "CDN";

    }
}
