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
    /// TtmlEmbed
    /// </summary>

    public class TtmlEmbed : BitmovinResource
    {
        /// <summary>
        /// The input stream to extract the subtitle from
        /// </summary>
        [JsonProperty(PropertyName = "inputStream")]
        public StreamInput InputStream { get; set; }
    }

}
