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
    /// Analysis metadata. Retains its original values in language-specific results.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// Version of the analysis software used to generate this result.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Attribution or disclaimer attached to the generated analysis.
        /// </summary>
        [JsonProperty(PropertyName = "disclaimer")]
        public string Disclaimer { get; set; }
    }
}
