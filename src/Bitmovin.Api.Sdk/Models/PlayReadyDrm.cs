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
    /// PlayReadyDrm
    /// </summary>

    public class PlayReadyDrm : Drm
    {
        /// <summary>
        /// 16 byte encryption key, 32 hexadecimal characters. Either key or keySeed is required
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <summary>
        /// Key seed to generate key. Either key or keySeed is required
        /// </summary>
        [JsonProperty(PropertyName = "keySeed")]
        public string KeySeed { get; set; }
        
        /// <summary>
        /// URL of the license server
        /// </summary>
        [JsonProperty(PropertyName = "laUrl")]
        public string LaUrl { get; set; }
        
        /// <summary>
        /// Base64 encoded pssh payload
        /// </summary>
        [JsonProperty(PropertyName = "pssh")]
        public string Pssh { get; set; }
        
        /// <summary>
        /// Method
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public PlayReadyEncryptionMethod Method { get; set; }
        
        /// <summary>
        /// Key identifier
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }
    }

}
