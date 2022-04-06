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
    /// SimpleEncodingVodJobOutput
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingVodJobUrlOutput), "URL")]
    [JsonSubtypes.KnownSubType(typeof(SimpleEncodingVodJobCdnOutput), "CDN")]

    public class SimpleEncodingVodJobOutput
    {
    }
}