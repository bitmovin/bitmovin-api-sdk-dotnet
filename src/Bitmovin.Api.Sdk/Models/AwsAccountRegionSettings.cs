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
        /// Maximum amount of encoding coordinators and workers allowed in this region at any time. Leave empty for no limit.
        /// </summary>
        [JsonProperty(PropertyName = "maximumAmountOfCoordinatorsAndWorkersInRegion")]
        public long? MaximumAmountOfCoordinatorsAndWorkersInRegion { get; set; }

        /// <summary>
        /// Limit the amount of money to spend in this region on this account. Leave empty for no limit.
        /// </summary>
        [JsonProperty(PropertyName = "maxMoneyToSpendPerMonth")]
        public double? MaxMoneyToSpendPerMonth { get; set; }

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
        /// Which machine types are allowed to be deployed. Leave empty for no machine type restrictions.
        /// </summary>
        [JsonProperty(PropertyName = "machineTypes")]
        public List<string> MachineTypes { get; set; } = new List<string>();

        /// <summary>
        /// Custom SSH port. Valid values: 1 - 65535. Leave empty if the default SSH port 22 is OK.
        /// </summary>
        [JsonProperty(PropertyName = "sshPort")]
        public int? SshPort { get; set; }
    }
}
