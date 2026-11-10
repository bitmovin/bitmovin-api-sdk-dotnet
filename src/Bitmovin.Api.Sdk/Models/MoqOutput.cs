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
    /// Media over QUIC (MoQ) output. Publishes the live encoding to a MoQ relay over MoQ Transport (MoQT).  **BETA:** MoQ output is a beta feature. MoQ Transport is still an evolving IETF draft and relay implementations differ, so it might not work with some MoQ relays. It has been tested with &#x60;DRAFT_16&#x60; and the Cloudflare MoQ relay. 
    /// </summary>
    public class MoqOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "MOQ";
#pragma warning restore CS0414

        /// <summary>
        /// URL of the MoQ relay the encoder publishes to. (required)
        /// </summary>
        [JsonProperty(PropertyName = "relayUrl")]
        public string RelayUrl { get; set; }

        /// <summary>
        /// MoQT Track Namespace under which the tracks are published. A tuple of one to 32 fields, not a URI or path. (required)
        /// </summary>
        [JsonProperty(PropertyName = "trackNamespace")]
        public List<string> TrackNamespace { get; set; } = new List<string>();

        /// <summary>
        /// MoQ Transport draft version to use for the session with the relay. (required)
        /// </summary>
        [JsonProperty(PropertyName = "draftVersion")]
        public MoqDraftVersion? DraftVersion { get; set; }

        /// <summary>
        /// Token sent to the MoQ relay as the MoQT AUTHORIZATION TOKEN parameter. This is the only supported authentication mechanism; credentials in the relay URL are not used.
        /// </summary>
        [JsonProperty(PropertyName = "authToken")]
        public string AuthToken { get; set; }

        /// <summary>
        /// Token type of the MoQT AUTHORIZATION TOKEN parameter (IANA MoQ Auth Token Type registry or private-use range). Only used together with authToken. If not set, the encoder applies its default token type.
        /// </summary>
        [JsonProperty(PropertyName = "authTokenType")]
        public int? AuthTokenType { get; set; }
    }
}
