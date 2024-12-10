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
    /// GCE Cloud Connect Account. Configure either by passing a single service account credentials JSON string or by passing the service account email, private key and project ID individually. 
    /// </summary>
    public class GceAccount : BitmovinResource
    {
        /// <summary>
        /// GCP service account credentials JSON
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountCredentials")]
        public string ServiceAccountCredentials { get; set; }

        /// <summary>
        /// Email address of the Google service account that will be used to spin up VMs
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountEmail")]
        public string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Google private key of the Google service account that will be used to spin up VMs
        /// </summary>
        [JsonProperty(PropertyName = "privateKey")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// ID of the GCP project in which the VMs are supposed to run.
        /// </summary>
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
    }
}
