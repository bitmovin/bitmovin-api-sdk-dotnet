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
    /// Mp3Muxing
    /// </summary>
    public class Mp3Muxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "MP3";

        /// <summary>
        /// Name of the new file (required)
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
    }
}
