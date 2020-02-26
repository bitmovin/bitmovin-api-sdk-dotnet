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
    /// GcsInput
    /// </summary>
    public class GcsInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "GCS";

        /// <summary>
        /// Name of the bucket (required)
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }

        /// <summary>
        /// The cloud region in which the bucket is located. Is used to determine the ideal location for your encodings automatically.
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public GoogleCloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// GCS access key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// GCS secret key (required)
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }
    }
}
