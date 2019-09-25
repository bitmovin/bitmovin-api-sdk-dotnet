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
    /// CencDrm
    /// </summary>

    public class CencDrm : Drm
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "CENC";

        /// <summary>
        /// 16 byte encryption key, 32 hexadecimal characters (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <summary>
        /// 16 byte encryption key id. Required for any other DRM but FairPlay
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }
        
        /// <summary>
        /// The encryption method to use. Default is &#x60;CTR&#x60; (required)
        /// </summary>
        [JsonProperty(PropertyName = "encryptionMode")]
        public EncryptionMode? EncryptionMode { get; set; }
        
        /// <summary>
        /// Size of the initialization vector
        /// </summary>
        [JsonProperty(PropertyName = "ivSize")]
        public IvSize? IvSize { get; set; }
        
        /// <summary>
        /// Enables compatibility with the Protected Interoperable File Format (PIFF) specification
        /// </summary>
        [JsonProperty(PropertyName = "enablePiffCompatibility")]
        public bool? EnablePiffCompatibility { get; set; }
        
        /// <summary>
        /// Configuration for Widevine DRM
        /// </summary>
        [JsonProperty(PropertyName = "widevine")]
        public CencWidevine Widevine { get; set; }
        
        /// <summary>
        /// Configuration for PlayReady DRM
        /// </summary>
        [JsonProperty(PropertyName = "playReady")]
        public CencPlayReady PlayReady { get; set; }
        
        /// <summary>
        /// Configuration for Marlin DRM
        /// </summary>
        [JsonProperty(PropertyName = "marlin")]
        public CencMarlin Marlin { get; set; }
        
        /// <summary>
        /// Configuration for FairPlay DRM
        /// </summary>
        [JsonProperty(PropertyName = "fairPlay")]
        public CencFairPlay FairPlay { get; set; }
    }

}
