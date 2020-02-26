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
    /// GceAccount
    /// </summary>
    public class GceAccount : BitmovinResource
    {
        /// <summary>
        /// Email address of the Google service account that will be used to spin up VMs (required)
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountEmail")]
        public string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Google private key of the Google service account that will be used to spin up VMs (required)
        /// </summary>
        [JsonProperty(PropertyName = "privateKey")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// ID of the GCP project in which the VMs are supposed to run. (required)
        /// </summary>
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
    }
}
