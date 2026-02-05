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
    /// RotateFilter
    /// </summary>
    public class RotateFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "ROTATE";
#pragma warning restore CS0414

        /// <summary>
        /// Rotation of the video in degrees. A positive value will rotate the video clockwise and a negative one counter clockwise. (required)
        /// </summary>
        [JsonProperty(PropertyName = "rotation")]
        public int? Rotation { get; set; }
    }
}
