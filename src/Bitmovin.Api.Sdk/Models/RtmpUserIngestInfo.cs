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
    /// Details about user info from rtmp ingest.
    /// </summary>
    public class RtmpUserIngestInfo
    {
        /// <summary>
        /// Client public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// RTMP application name.
        /// </summary>
        [JsonProperty(PropertyName = "app")]
        public string App { get; set; }

        /// <summary>
        /// Client stream key.
        /// </summary>
        [JsonProperty(PropertyName = "streamKey")]
        public string StreamKey { get; set; }

        /// <summary>
        /// Flash version string / encoder identity.
        /// </summary>
        [JsonProperty(PropertyName = "flashVersion")]
        public string FlashVersion { get; set; }

        /// <summary>
        /// Session/client connection ID.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Server action.
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }
    }
}
