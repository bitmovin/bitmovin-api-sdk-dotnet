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
    /// BitmovinStreamEncodingTask
    /// </summary>
    public class BitmovinStreamEncodingTask
    {
        /// <summary>
        /// Quality of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public BitmovinStreamQuality? Quality { get; internal set; }

        /// <summary>
        /// Current state of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public BitmovinStreamEncodingStatus? Status { get; internal set; }
    }
}
