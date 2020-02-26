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
    /// KubernetesCluster
    /// </summary>
    public class KubernetesCluster : BitmovinResource
    {
        /// <summary>
        /// Shows if the Bitmovin Agent is alive (required)
        /// </summary>
        [JsonProperty(PropertyName = "online")]
        public bool? Online { get; internal set; }

        /// <summary>
        /// Shows if the Kubernetes cluster is accessible by the Bitmovin Agent (required)
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; internal set; }

        /// <summary>
        /// AgentDeploymentDownloadUrl
        /// </summary>
        [JsonProperty(PropertyName = "agentDeploymentDownloadUrl")]
        public string AgentDeploymentDownloadUrl { get; internal set; }
    }
}
