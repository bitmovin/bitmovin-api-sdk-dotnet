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
    /// InfrastructureSettings
    /// </summary>

    public class InfrastructureSettings
    {
        /// <summary>
        /// Id of a custom infrastructure, e.g., Kubernetes Cluster
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }
        
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion? CloudRegion { get; set; }
    }

}
