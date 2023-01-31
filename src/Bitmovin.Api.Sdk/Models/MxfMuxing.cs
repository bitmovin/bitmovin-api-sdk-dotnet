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
    /// MxfMuxing
    /// </summary>
    public class MxfMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "MXF";

        /// <summary>
        /// Name of the output file (required)
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
    }
}
