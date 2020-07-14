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
    /// InputFactor
    /// </summary>
    public class InputFactor
    {
        /// <summary>
        /// Codec
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public InputFactorCodec Codec { get; set; }

        /// <summary>
        /// Bitrate
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public InputFactorBitrate Bitrate { get; set; }
    }
}
