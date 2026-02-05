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
    /// Mp3AudioConfiguration
    /// </summary>
    public class Mp3AudioConfiguration : AudioConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "MP3";
#pragma warning restore CS0414

        /// <summary>
        /// Channel layout of the audio codec configuration
        /// </summary>
        [JsonProperty(PropertyName = "channelLayout")]
        public ChannelLayout? ChannelLayout { get; set; }
    }
}
