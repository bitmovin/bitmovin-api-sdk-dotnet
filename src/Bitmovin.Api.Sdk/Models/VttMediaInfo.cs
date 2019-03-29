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
    /// VttMediaInfo
    /// </summary>

    public class VttMediaInfo : BasicMediaInfo
    {
        /// <summary>
        /// The URL of the referenced VTT file
        /// </summary>
        [JsonProperty(PropertyName = "vttUrl")]
        public string VttUrl { get; set; }
        
        /// <summary>
        /// The URI of the Rendition
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <summary>
        /// A value of true indicates that the Rendition contains content which is considered essential to play.
        /// </summary>
        [JsonProperty(PropertyName = "forced")]
        public bool? Forced { get; set; }
    }

}
