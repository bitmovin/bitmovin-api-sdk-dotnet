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
    /// ConformFilter
    /// </summary>
    public class ConformFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "CONFORM";

        /// <summary>
        /// The FPS the input should be changed to.
        /// </summary>
        [JsonProperty(PropertyName = "targetFps")]
        public double? TargetFps { get; set; }
    }
}
