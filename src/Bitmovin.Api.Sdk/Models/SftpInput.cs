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
    /// SftpInput
    /// </summary>
    public class SftpInput : Input
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "SFTP";
#pragma warning restore CS0414

        /// <summary>
        /// Host Url or IP of the SFTP server (required)
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Port to use, standard for SFTP: 22
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Use passive mode. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "passive")]
        public bool? Passive { get; set; }

        /// <summary>
        /// Your SFTP Username
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Your SFTP password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}
