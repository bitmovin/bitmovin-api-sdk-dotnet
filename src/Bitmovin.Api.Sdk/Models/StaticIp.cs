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
    /// StaticIp
    /// </summary>
    public class StaticIp : BitmovinResponse
    {
        /// <summary>
        /// The IPv4 address of the static ip
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; internal set; }

        /// <summary>
        /// Required if the static IP should be created for an AWS infrastructure account.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }

        /// <summary>
        /// Status of the Static Ip
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public StaticIpStatus? Status { get; internal set; }

        /// <summary>
        /// The region of the static Ip (required)
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public CloudRegion? Region { get; set; }
    }
}
