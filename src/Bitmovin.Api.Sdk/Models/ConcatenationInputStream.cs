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
        /// <summary>
        /// Concatenation configuration for the output of this stream
        /// </summary>
        [JsonProperty(PropertyName = "concatenation")]
        public List<ConcatenationInputConfiguration> Concatenation { get; set; } = new List<ConcatenationInputConfiguration>();
    }

}
