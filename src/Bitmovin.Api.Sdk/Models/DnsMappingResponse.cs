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
    /// DnsMappingResponse
    /// </summary>
    public class DnsMappingResponse : BitmovinResource
    {
        /// <summary>
        /// Subdomain used for the DNS mapping
        /// </summary>
        [JsonProperty(PropertyName = "subdomain")]
        public string Subdomain { get; set; }

        /// <summary>
        /// Resolved hostname for the DNS mapping
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; internal set; }

        /// <summary>
        /// ID of the encoding this DNS mapping belongs to
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// IP address that the hostname resolves to
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; internal set; }
    }
}
