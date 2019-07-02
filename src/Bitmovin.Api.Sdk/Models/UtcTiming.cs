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
    /// UtcTiming
    /// </summary>

    public class UtcTiming
    {
        /// <summary>
        /// The server to get the time from (required)
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <summary>
        /// The scheme id to use. Please refer to the DASH standard. (required)
        /// </summary>
        [JsonProperty(PropertyName = "schemeIdUri")]
        public string SchemeIdUri { get; set; }
    }

}
