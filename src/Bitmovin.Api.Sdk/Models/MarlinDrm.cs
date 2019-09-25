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
    /// MarlinDrm
    /// </summary>

    public class MarlinDrm : Drm
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "MARLIN";

        /// <summary>
        /// 16 byte key in hex (32 characters) (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <summary>
        /// 16 byte key in hex (32 characters) (required)
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }
    }

}
