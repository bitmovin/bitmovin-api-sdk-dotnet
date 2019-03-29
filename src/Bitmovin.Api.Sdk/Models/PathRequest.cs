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
    /// PathRequest
    /// </summary>

    public class PathRequest
    {
        /// <summary>
        /// Path
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <summary>
        /// Recursive
        /// </summary>
        [JsonProperty(PropertyName = "recursive")]
        public bool? Recursive { get; set; }
        
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion CloudRegion { get; set; }
    }

}
