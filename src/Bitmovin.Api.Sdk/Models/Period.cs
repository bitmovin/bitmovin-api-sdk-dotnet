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
    /// Period
    /// </summary>

    public class Period : BitmovinResponse
    {
        /// <summary>
        /// Starting time in seconds
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public double? Start { get; set; }
        
        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
    }

}
