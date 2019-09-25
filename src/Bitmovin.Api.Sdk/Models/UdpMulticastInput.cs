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
    /// UdpMulticastInput
    /// </summary>

    public class UdpMulticastInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "UDP_MULTICAST";

        /// <summary>
        /// Host name or IP address to use (required)
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Port to use (required)
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }

}
