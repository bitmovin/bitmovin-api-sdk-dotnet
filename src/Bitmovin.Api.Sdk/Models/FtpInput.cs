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
    /// FtpInput
    /// </summary>

    public class FtpInput : Input
    {
        /// <summary>
        /// Host URL or IP of the FTP server
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Port to use, standard for FTP: 21
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        
        /// <summary>
        /// Use passive mode. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "passive")]
        public bool? Passive { get; set; }
        
        /// <summary>
        /// Your FTP Username
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <summary>
        /// Your FTP password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Ensure that connections originate from the declared ftp host. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "remoteVerificationEnabled")]
        public bool? RemoteVerificationEnabled { get; set; }
    }

}
