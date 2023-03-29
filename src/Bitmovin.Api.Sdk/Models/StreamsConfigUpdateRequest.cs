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
    /// StreamsConfigUpdateRequest
    /// </summary>
    public class StreamsConfigUpdateRequest
    {
        /// <summary>
        /// Player style config (required)
        /// </summary>
        [JsonProperty(PropertyName = "playerStyle")]
        public Object PlayerStyle { get; set; }
    }
}
