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
    /// AnalysisStartRequest
    /// </summary>

    public class AnalysisStartRequest
    {
        /// <summary>
        /// Path
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion CloudRegion { get; set; }
    }

}
