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
    /// SrtInput
    /// </summary>

    public class SrtInput : Input
    {
        /// <summary>
        /// The SRT mode to use (required)
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public SrtMode? Mode { get; set; }
        
        /// <summary>
        /// The name or IP of the host providing the SRT stream (only used in CALLER mode)
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// The port to connect to or listen on. Has to be one of [2088, 2089, 2090, 2091] when using LISTENER mode. (required)
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        
        /// <summary>
        /// The path parameter of the SRT stream
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <summary>
        /// The maximum accepted transmission latency in milliseconds (when both parties set different values, the maximum of the two is used for both)
        /// </summary>
        [JsonProperty(PropertyName = "latency")]
        public int? Latency { get; set; }
        
        /// <summary>
        /// The passphrase used to secure the SRT stream. For AES-128 encryption, you must enter a 16-character passphrase; for AES-256, you must enter a 32-character passphrase
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string Passphrase { get; set; }
        
        /// <summary>
        /// The type of AES encryption determines the length of the key (passphrase). AES-128 uses a 16-character (128-bit) passphrase, and AES-256 uses a 32-character (256-bit) passphrase.
        /// </summary>
        [JsonProperty(PropertyName = "keyLength")]
        public int? KeyLength { get; set; }
        
        /// <summary>
        /// BackupSrtInputs
        /// </summary>
        [JsonProperty(PropertyName = "backupSrtInputs")]
        public BackupSrtInputs BackupSrtInputs { get; set; }
    }

}
