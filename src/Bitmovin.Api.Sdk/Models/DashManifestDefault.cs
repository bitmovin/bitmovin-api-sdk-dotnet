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
    /// V2 of the default dash manifest is an experimental feature and might be subject to change in the future. 
    /// </summary>
    public class DashManifestDefault : DashManifest
    {
        /// <summary>
        /// The id of the encoding to create a default manifest from. Required: encodingId or periods
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// The version of the default manifest generator
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public DashManifestDefaultVersion? Version { get; set; }

        /// <summary>
        /// Adds a period for every item. Required: encodingId or periods
        /// </summary>
        [JsonProperty(PropertyName = "periods")]
        public List<DefaultDashManifestPeriod> Periods { get; set; } = new List<DefaultDashManifestPeriod>();
    }
}
