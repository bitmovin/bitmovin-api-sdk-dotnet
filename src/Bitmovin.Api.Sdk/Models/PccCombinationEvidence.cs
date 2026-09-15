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
    /// PccCombinationEvidence
    /// </summary>
    public class PccCombinationEvidence
    {
        /// <summary>
        /// The codec, as the shared contract spells it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// The content protection, as the shared contract spells it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "protection")]
        public string Protection { get; set; }

        /// <summary>
        /// Device pools that played it, which is what proves the stream behind it works at all. (required)
        /// </summary>
        [JsonProperty(PropertyName = "playedBy")]
        public decimal? PlayedBy { get; set; }

        /// <summary>
        /// Device pools that reported support for it and then failed to play it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "claimedNotPlayedBy")]
        public decimal? ClaimedNotPlayedBy { get; set; }

        /// <summary>
        /// Device pools that produced an answer either way. (required)
        /// </summary>
        [JsonProperty(PropertyName = "measuredBy")]
        public decimal? MeasuredBy { get; set; }

        /// <summary>
        /// No conformant stream can exist for this pairing, so it is neither gap nor result. (required)
        /// </summary>
        [JsonProperty(PropertyName = "notApplicable")]
        public bool? NotApplicable { get; set; }

        /// <summary>
        /// Hosts that served its stream. A host only — never a path and never a URL. (required)
        /// </summary>
        [JsonProperty(PropertyName = "assetHosts")]
        public List<string> AssetHosts { get; set; } = new List<string>();

        /// <summary>
        /// Hosts that licensed it. A separate axis from the one above: without both, a device refusing a codec cannot be told from a stream that stopped being served. (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseServers")]
        public List<string> LicenseServers { get; set; } = new List<string>();
    }
}
