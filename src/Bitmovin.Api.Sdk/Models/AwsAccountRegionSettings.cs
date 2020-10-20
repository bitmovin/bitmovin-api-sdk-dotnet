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
    /// AwsAccountRegionSettings
    /// </summary>
    public class AwsAccountRegionSettings : BitmovinResource
    {
        /// <summary>
        /// Limit for the amount of running encodings at a time. Leave empty for no limit.
        /// </summary>
        [JsonProperty(PropertyName = "limitParallelEncodings")]
        public long? LimitParallelEncodings { get; set; }

        /// <summary>
        /// Id of the security group for encoding instances (required)
        /// </summary>
        [JsonProperty(PropertyName = "securityGroupId")]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Id of the subnet for encoding instances (required)
        /// </summary>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Custom SSH port. Valid values: 1 - 65535. Leave empty if the default SSH port 22 is OK.
        /// </summary>
        [JsonProperty(PropertyName = "sshPort")]
        public int? SshPort { get; set; }
    }
}
