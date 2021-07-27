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
    /// S3Output
    /// </summary>
    public class S3Output : Output
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "S3";

        /// <summary>
        /// Amazon S3 bucket name (required)
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }

        /// <summary>
        /// Amazon S3 access key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Amazon S3 secret key (required)
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }

        /// <summary>
        /// If set a user defined tag (x-amz-meta-) with that key will be used to store the MD5 hash of the file.
        /// </summary>
        [JsonProperty(PropertyName = "md5MetaTag")]
        public string Md5MetaTag { get; set; }

        /// <summary>
        /// The cloud region in which the bucket is located. Is used to determine the ideal location for your encodings automatically.
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public AwsCloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// Specifies the method used for authentication. Must be set to S3_V2 if the region supports both V2 and V4, but the bucket allows V2 only (see https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region)
        /// </summary>
        [JsonProperty(PropertyName = "signatureVersion")]
        public S3SignatureVersion? SignatureVersion { get; set; }
    }
}
