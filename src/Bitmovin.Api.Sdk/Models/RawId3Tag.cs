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
    /// RawId3Tag
    /// </summary>

    public class RawId3Tag : Id3Tag
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "RAW";

        /// <summary>
        /// Base64 Encoded Data (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public string Bytes { get; set; }
    }

}
