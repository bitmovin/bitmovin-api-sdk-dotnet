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
    /// PccHdrFinding
    /// </summary>
    public class PccHdrFinding
    {
        /// <summary>
        /// The device pool, under the name the rest of the report shows it by. (required)
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }

        /// <summary>
        /// Codec
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// Protection
        /// </summary>
        [JsonProperty(PropertyName = "protection")]
        public string Protection { get; set; }

        /// <summary>
        /// What was found, in one paragraph. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sentence")]
        public string Sentence { get; set; }
    }
}
