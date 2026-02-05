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
    /// PassthroughAudioConfiguration
    /// </summary>
    public class PassthroughAudioConfiguration : CodecConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "AUDIO_PASSTHROUGH";
#pragma warning restore CS0414

    }
}
