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
    /// ReprioritizeEncodingRequest
    /// </summary>
    public class ReprioritizeEncodingRequest
    {
        /// <summary>
        /// Priority of the Encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
    }
}
