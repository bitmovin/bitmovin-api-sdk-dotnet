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
    /// CencFairPlay
    /// </summary>

    public class CencFairPlay
    {
        /// <summary>
        /// Initialization vector as hexadecimal string
        /// </summary>
        [JsonProperty(PropertyName = "iv")]
        public string Iv { get; set; }
        
        /// <summary>
        /// URL of the licensing server
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }

}
