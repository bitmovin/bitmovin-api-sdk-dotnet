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
    /// TimeSpan
    /// </summary>

    public class TimeSpan
    {
        /// <summary>
        /// Start offset of the time frame in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public long? From { get; set; }
        
        /// <summary>
        /// End offset of the time frame in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public long? To { get; set; }
    }

}
