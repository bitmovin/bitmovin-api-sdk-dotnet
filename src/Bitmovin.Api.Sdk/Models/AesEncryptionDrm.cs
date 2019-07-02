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
    /// AesEncryptionDrm
    /// </summary>

    public class AesEncryptionDrm : Drm
    {
        /// <summary>
        /// 16 byte Encryption key, 32 hexadecimal characters (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <summary>
        /// 16 byte initialization vector
        /// </summary>
        [JsonProperty(PropertyName = "iv")]
        public string Iv { get; set; }
        
        /// <summary>
        /// Path relative to the output for referencing in the manifest. If this value is not set the key file will be written automatically to the output folder.
        /// </summary>
        [JsonProperty(PropertyName = "keyFileUri")]
        public string KeyFileUri { get; set; }
        
        /// <summary>
        /// Method
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public AesEncryptionMethod? Method { get; set; }
    }

}
