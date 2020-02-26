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
    /// KubernetesClusterConfiguration
    /// </summary>
    public class KubernetesClusterConfiguration
    {
        /// <summary>
        /// Number of parallel scheduled encodings on the Kubernetes cluster (required)
        /// </summary>
        [JsonProperty(PropertyName = "parallelEncodings")]
        public int? ParallelEncodings { get; set; }

        /// <summary>
        /// Number of worker nodes used for each encoding on the Kubernetes cluster (required)
        /// </summary>
        [JsonProperty(PropertyName = "workersPerEncoding")]
        public int? WorkersPerEncoding { get; set; }
    }
}
