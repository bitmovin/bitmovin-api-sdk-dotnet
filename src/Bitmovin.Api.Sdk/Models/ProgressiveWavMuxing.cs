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
    /// ProgressiveWavMuxing
    /// </summary>
    public class ProgressiveWavMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "PROGRESSIVE_WAV";

        /// <summary>
        /// Name of the output file (required)
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
    }
}
