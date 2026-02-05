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
    /// ProgressiveMovMuxing
    /// </summary>
    public class ProgressiveMovMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "PROGRESSIVE_MOV";
#pragma warning restore CS0414

        /// <summary>
        /// Name of the output file
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
    }
}
