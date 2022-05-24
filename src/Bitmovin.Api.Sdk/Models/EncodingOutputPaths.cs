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
    /// EncodingOutputPaths
    /// </summary>
    public class EncodingOutputPaths
    {
        /// <summary>
        /// Output
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public Output Output { get; set; }

        /// <summary>
        /// Paths
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public EncodingOutputPathsForOutput Paths { get; set; }
    }
}
