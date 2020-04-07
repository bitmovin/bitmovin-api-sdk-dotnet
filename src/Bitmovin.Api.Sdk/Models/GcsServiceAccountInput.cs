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
    /// GcsServiceAccountInput
    /// </summary>
    public class GcsServiceAccountInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "GCS_SERVICE_ACCOUNT";

        /// <summary>
        /// GCS projectId (required)
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountCredentials")]
        public string ServiceAccountCredentials { get; set; }

        /// <summary>
        /// Name of the bucket (required)
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }

        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public GoogleCloudRegion? CloudRegion { get; set; }
    }
}
