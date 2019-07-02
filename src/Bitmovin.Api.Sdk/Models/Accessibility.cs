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
    /// Accessibility
    /// </summary>

    public class Accessibility
    {
        /// <summary>
        /// Can be either list of languages or a complete map of services (or CC channels, in CEA-608 terminology) (required)
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <summary>
        /// The scheme id to use. Please refer to the DASH standard. (required)
        /// </summary>
        [JsonProperty(PropertyName = "schemeIdUri")]
        public string SchemeIdUri { get; set; }
    }

}
