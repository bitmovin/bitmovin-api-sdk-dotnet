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
    /// HlsManifestDefault
    /// </summary>

    public class HlsManifestDefault : HlsManifest
    {
        /// <summary>
        /// The id of the encoding to create a default manifest from (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }
        
        /// <summary>
        /// The version of the default manifest generator
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public HlsManifestDefaultVersion? Version { get; set; }
    }

}
