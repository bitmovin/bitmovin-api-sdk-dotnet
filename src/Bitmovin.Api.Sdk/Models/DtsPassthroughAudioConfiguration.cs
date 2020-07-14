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
    /// DtsPassthroughAudioConfiguration
    /// </summary>
    public class DtsPassthroughAudioConfiguration : CodecConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DTS_PASSTHROUGH";

    }
}
