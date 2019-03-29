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
    /// KubernetesClusterPatch
    /// </summary>

    public class KubernetesClusterPatch
    {
        /// <summary>
        /// Shows if the Kubernetes cluster is accessible by the Bitmovin Agent
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }
    }

}
