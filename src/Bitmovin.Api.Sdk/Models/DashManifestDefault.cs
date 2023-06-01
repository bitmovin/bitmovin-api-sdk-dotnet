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
    /// DashManifestDefault
    /// </summary>
    public class DashManifestDefault : DashManifest
    {
        /// <summary>
        /// The id of the encoding to create a default manifest from. Either \&quot;encodingId\&quot; or \&quot;periods\&quot; is required.
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// Specifies the algorithm that determines which output of the given encoding is included into the manifest. Note that this is not related to the \&quot;manifestGenerator\&quot; version of the \&quot;Start\&quot; request.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public DashManifestDefaultVersion? Version { get; set; }

        /// <summary>
        /// Adds a period for every item. Either \&quot;periods\&quot; or \&quot;encodingId\&quot; is required.
        /// </summary>
        [JsonProperty(PropertyName = "periods")]
        public List<DefaultDashManifestPeriod> Periods { get; set; } = new List<DefaultDashManifestPeriod>();
    }
}
