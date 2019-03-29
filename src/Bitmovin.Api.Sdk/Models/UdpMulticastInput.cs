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
        /// <summary>
        /// Host name or IP address to use
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Port to use
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }

}
