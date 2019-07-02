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
    /// ClearKeyDrm
    /// </summary>

    public class ClearKeyDrm : Drm
    {
        /// <summary>
        /// 16 byte encryption key, 32 hexadecimal characters (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <summary>
        /// 16 byte key id (required)
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }
    }

}
