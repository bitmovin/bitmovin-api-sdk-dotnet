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
    /// ConcatenationInputStream
    /// </summary>
    public class ConcatenationInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "CONCATENATION";
#pragma warning restore CS0414

        /// <summary>
        /// Concatenation configuration for the output of this stream
        /// </summary>
        [JsonProperty(PropertyName = "concatenation")]
        public List<ConcatenationInputConfiguration> Concatenation { get; set; } = new List<ConcatenationInputConfiguration>();
    }
}
